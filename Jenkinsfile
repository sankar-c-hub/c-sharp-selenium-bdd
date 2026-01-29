pipeline {
    agent any

    environment {
        DOTNET_CLI_TELEMETRY_OPTOUT = '1'
        DOTNET_SKIP_FIRST_TIME_EXPERIENCE = '1'
        ASPNETCORE_ENVIRONMENT = 'CI'
    }

    stages {

        stage('Clone Repository') {
            steps {
                echo '📥 Cloning repository...'
                checkout scm
            }
        }

        stage('Verify Environment') {
            steps {
                echo '🔍 Checking .NET & Chrome versions...'
                sh '''
                    dotnet --version
                    google-chrome --version || chromium-browser --version
                '''
            }
        }

        stage('Build & Run Tests') {
            steps {
                echo '🚀 Restoring, building, and running tests...'
                sh '''
                    dotnet restore BddSelenium.sln
                    dotnet build BddSelenium.sln --configuration Release --no-restore
                    dotnet test BddSelenium.sln \
                        --configuration Release \
                        --no-build \
                        --logger "trx;LogFileName=test-results.trx"
                '''
            }
        }

        stage('Publish Reports') {
            steps {
                echo '📊 Publishing test reports...'
            }
        }
    }

    post {
        always {
            echo '📦 Archiving test results and reports...'
    
            // NUnit / TRX results
            junit '**/TestResults/*.trx'
    
            // Your custom report folder
            archiveArtifacts artifacts: 'BddSelenium/reports/**', allowEmptyArchive: true
        }
    
        success {
            echo '✅ Tests passed'
        }
    
        failure {
            echo '❌ Tests failed'
        }
}

}
