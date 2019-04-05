
# Software Engineer Test

## Getting started
All of these tasks are located under the same Solution file named [ApplicitaRecruitment.sln](Code/Applicita.Recruitment.sln) located in the Code folder of this repository. The projects are named after the tasks they are associated to.

## Task 1 - Replicate the Linq Where Method
1. Implement the Linq Where method's functionality without using the `System.Linq` namespace.
2. Write Tests to prove the code works properly.

## Task 2 - Add validation to existing API method
1. Implement the following validation rules when the Customer entity is posted to the Customer controllers post method:

    |Field|Rule|
    |-|-|
    |Name|Not empty, Must be at least 2 characters|
    |Age|Must be a whole number|
    |Favorite Programming Language 1|Must be at least 1 character long|
    |Favorite Programming Language 2|Must be at least 1 character long, Must not be the same as "Favorite Programming Language 1"|

    Please feel free to bring in a external library if needs be. Your solution must be representitive of production code.

2. Write Tests to prove the code works properly.

## Task 3 -  Secure the API

1. Secure the API given in Task 2 with Client Credential based security. Your securing server credentials are as follows:

    |Setting|Value|
    |-|-|
    |Token Endpoint|https://applicita-idp-server.azurewebsites.net/|
    |ClientId|ApplicitaServiceClient|
    |Secret|secret123|
    |Scope|customer-api|

    Feel free to change the hosting/startup pipeline if it helps.

## Task 4 - Path to production
In a short paragrah, how would you get the API used in Step 2 and 3 to production?
