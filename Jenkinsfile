pipeline {

    agent { label 'servidor_plss'}

//     triggers {
//         githubPush()
//     }

    stages {
        stage ('webhook'){
            steps{
                script{
                    hook = registerWebhook()
                    echo "Waiting for POST to ${hook.url}"
                    data = waitForWebhook hook
                    echo "Webhook called with data: ${data}"
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
