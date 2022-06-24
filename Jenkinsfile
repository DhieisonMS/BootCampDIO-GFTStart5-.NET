pipeline {
    agent { label 'windows' }
    stages {
        
        stage('Build1'){
            steps {
                script{
                    echo "teste"
                    echo "teste2"
                    dir('C:\\dotnet\\') {
                      bat "dotnet.exe build c:\\teste1\\"
                      bat "dotnet publish c:\\teste1\\ -c Release -o c:\\ttttttttt"
                    }
                    
                }
            }
        }
            
            stage('Build2'){
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
                    echo "teste"
                    echo "teste2"
                    dir('C:\\dotnet\\') {
                      bat "dotnet.exe restore c:\\teste1\\"  
                    }
                    
                }
             }
           }
        
  
        
    
    }
}