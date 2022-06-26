pipeline {
    
    agent { 
        label 'windows'
    }

    triggers {
        pollSCM "*/1 * * * *"

    stages {
        stage('Build1'){
            when {
                changeset "**/JogoRPG/DUNGEON_DIO/*"
            }
            steps {
                script{
                    // bat "dotnet"
                    dir('C:\\dotnet\\') {
                      bat "dotnet.exe build c:\\teste1\\"
                      bat "dotnet publish c:\\teste1\\ -c Release -o c:\\ttttttttt"
                    }
                }
            }
        }

            
            stage('Build2'){
            when {
                    changeset "**/JogoRPG/DUNGEON_DIO copy/*"
                 }
            steps {
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
                    bat "dotnet restore ./JogoRPG/DUNGEON_DIO/ "
                    // dir('C:\\dotnet\\') {
                    //   bat "dotnet.exe restore c:\\teste1\\"  
                    // }   
                    // 
                }
             }
           } 
    }
}
