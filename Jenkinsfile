pipeline {
    agent any

    stages {
        stage('Clean workspace') {
            steps {
                cleanWs()
            }
        }
        stage('Test') {
            steps {
                bat dotnet restore
            }
        }
        stage('Deploy') {
            steps {
               cd c
            }
        }
    }
}