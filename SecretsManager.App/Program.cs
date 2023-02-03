﻿
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

var secretsManagerClient = new AmazonSecretsManagerClient();

var listSecretVersionsRequest = new ListSecretVersionIdsRequest
{
    SecretId = "ApiKey",
    IncludeDeprecated = true
};

var versionResponse = await secretsManagerClient.ListSecretVersionIdsAsync(listSecretVersionsRequest);

var request = new GetSecretValueRequest
{
    SecretId = "ApiKey",
    //VersionStage = "AWSCURRENT"
    VersionId = "be99f6e2-7ccb-4dd4-8d8c-aa842ac93e41"
};

var response = await secretsManagerClient.GetSecretValueAsync(request);

Console.WriteLine(response.SecretString);

//var describeSecretRequest = new DescribeSecretRequest
//{
//    SecretId = "ApiKey"
//};

//var describeResponse = await secretsManagerClient.DescribeSecretAsync(describeSecretRequest);

//Console.WriteLine();