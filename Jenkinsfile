pipeline {
    agent any
    stages {
        stage('Cloner le code') {
            steps {
                // Clone du code depuis GitHub
                git 'https://github.com/Ouma-yma-el49/calculatrice.git'
            }
        }
        stage('Build') {
            steps {
                // Compilation du projet avec dotnet
                bat 'dotnet build'
            }
        }
        stage('Exécuter les tests unitaires') {
            steps {
                // Exécution des tests NUnit
                bat 'dotnet test --logger:nunit;LogFilePath=test-results.xml'
            }
        }
        stage('Rapports de tests') {
            steps {
                // Publication des rapports NUnit
                publishNUnit testResultsPattern: 'test-results.xml'
            }
        }
        stage('Dockeriser l’application') {
            steps {
                // Construire et publier l'image Docker
                script {
                    def app = docker.build('oumaima/calculatrice')
                    app.push('latest')
                }
            }
        }
    }
}
