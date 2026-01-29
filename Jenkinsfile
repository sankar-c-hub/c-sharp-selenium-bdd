pipeline {
    agent any

    tools {
        dotnet 'dotnet8'
    }

    environment {
        DOTNET_CLI_TELEMETRY_OPTOUT = '1'
        DOTNET_SKIP_FIRST_TIME_EXPERIENCE = '1'
        ASPNETCORE_ENVIRONMENT = 'CI'
    }

    stages {

        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Verify Environment') {
            steps {
                sh '''
                    dotnet --version
                    google-chrome --version || chromium-browser --version
                '''
            }
        }

        stage('Restore') {
            steps {
                sh 'dotnet restore BddSelenium.sln'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build BddSelenium.sln --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh '''
                    dotnet test BddSelenium.sln \
                    --configuration Release \
                    --no-build \
                    --logger "trx;LogFileName=test-results.trx"
                '''
            }
        }
    }

    post {
        always {
            echo 'Publishing test results...'
            junit '**/TestResults/*.trx'
            archiveArtifacts artifacts: '**/TestResults/**', allowEmptyArchive: true
        }

        failure {
            echo '❌ Build failed'
        }

        success {
            echo '✅ Build and tests passed'
        }
    }
}
