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
                echo '🚀 Building and running tests...'
                sh '''
                    cd BddSelenium
                    dotnet build
                    dotnet test
                '''
            }
        }

        stage('Publish Reports') {
            steps {
                echo '📊 Publishing test reports...'
            }
        }
    }
}


