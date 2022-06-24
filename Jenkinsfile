pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                npm install
            }
        }
        stage('Test') {
            steps {
                npm build
            }
        }
        stage('Deploy') {
            steps {
               npm run
            }
        }
    }
}