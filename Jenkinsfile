def deployer (CHANGESET){
    stage('Build'){
            when {
                changeset "${CHANGESET}"
            }
            steps {
                script{
                      bat "dotnet.exe build c:\\teste1\\"
                      bat "dotnet publish c:\\teste1\\ -c Release -o c:\\ddddddd"
                }
            }
        }
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
}

pipeline {

    agent { label 'windows'}

    triggers {
        pollSCM "H/2 * * * *"
    }

    stages {

        // stage('Build'){
        //     when {
        //         changeset "**/JogoRPG/DUNGEON_DIO/*"
        //     }
        //     steps {
        //         script{
        //               bat "dotnet.exe build c:\\teste1\\"
        //               bat "dotnet publish c:\\teste1\\ -c Release -o c:\\ddddddd"
        //         }
        //     }
        // }
        deployer("**/JogoRPG/DUNGEON_DIO/*")
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
