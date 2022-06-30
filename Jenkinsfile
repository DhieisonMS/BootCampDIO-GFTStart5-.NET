pipeline {

    agent { label 'servidor_plss'}

//     triggers {
//         githubPush()
//     }

    stages {
        
        stage('Build'){
            when {
                changeset "**/JogoRPG/DUNGEON_DIO/*"
            }
            steps {
                script{
                      bat "dotnet.exe build c:\\teste1\\"
                      bat "dotnet publish c:\\teste1\\ -c Release -o c:\\ddddddd"
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

    }
}
