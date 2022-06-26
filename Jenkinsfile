pipeline {
    
    agent { 
        label 'windows'
    }

    stages {
        stage('Build1'){
            when {
                changeset "**/JogoRPG/DUNGEON_DIO/*"
            }
            steps {
                script{

                    dir('C:\\dotnet\\') {
                      bat "dotnet.exe build c:\\teste1\\"
                      bat "dotnet publish c:\\teste1\\ -c Release -o c:\\ttttttttt"
                    }
                }
            }
        }

            
            stage('Build2'){
            steps {
                when {
                    changeset "**/JogoRPG/DUNGEON_DIO copy/*"
                 }
                script{
                    echo "teste"
                    echo "teste2"
                    dir('C:\\dotnet\\') {
                      bat "dotnet.exe restore c:\\teste2\\"  
                    }
                    
                }
            }
            
        }
            stage('Build'){
            steps {
                script{
                    dir('C:\\dotnet\\') {
                      bat "dotnet.exe restore c:\\teste1\\"  
                    }
                    
                }
             }
           } 
    }
}