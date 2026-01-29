switch ("${scm.branches[0].name}") {
case "staging":
  ALGOQA_DATA_BUCKET = "algoqastaging"
  break
case "preprod":
  ALGOQA_DATA_BUCKET = "algoqapreprod"
  break
case "main":
  ALGOQA_DATA_BUCKET = "algoqaproduction"
  break
default:
  ALGOQA_DATA_BUCKET = "algoqastaging"
  break
}

pipeline {

  agent any

  options {
    disableConcurrentBuilds()
  }

  stages {

    stage("Clean Workspace") {
      steps {
        script {
          cleanWs()
        }
      }
    }

    stage("GitHub Clone") {
      steps {
        script {
          sh """
          echo "The Source Repo branch is ${scm.branches[0].name}"
          echo "The target S3 bucket is ${ALGOQA_DATA_BUCKET}"
          """
          checkout scm
        }
      }
    }

    stage("Publish AlgoQA Attachment to S3 Bucket") {
      steps {
        script {
          sh """ 
            aws s3 cp ./algoAF_attachments s3://${ALGOQA_DATA_BUCKET}/AlgoQA_Data/algoAF_attachments --acl public-read --recursive
          """
        }
      }
    }

    stage("Publish AlgoQA CodeSnippet to S3 Bucket") {
      steps {
        script {
          sh """ 
            aws s3 cp ./codeSnippet s3://${ALGOQA_DATA_BUCKET}/AlgoQA_Data/codeSnippet --acl public-read --recursive
          """
        }
      }
    }
  }
}
