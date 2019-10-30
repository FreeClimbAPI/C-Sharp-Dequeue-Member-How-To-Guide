# CS - Dequeue a Member Tutorial

This project serves as a guide to help you build an application with FreeClimb. Specifically, the project will:

- Remove a call from a call queue and interact with the dequeue call

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://persephony-docs.readme.io/docs/getting-started-with-persephony).

## Setting up the Tutorial

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb-cs-sdk --version 1.0.0.1
   ```

2. Configure environment variables

   | ENV VARIABLE            | DESCRIPTION                                                                                                                                                                             |
   | ----------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
   | ACCOUNT_ID              | Account ID which can be found under [API Keys](https://www.persephony.com/dashboard/portal/account/authentication) in Dashboard                                                         |
   | AUTH_TOKEN              | Authentication Token which can be found under [API Keys](https://www.persephony.com/dashboard/portal/account/authentication) in Dashboard                                               |

3. Provide a value for the variables `queueuId` and `callId`. More about queues can be found [here](https://docs.persephony.com/reference/queues-1) and more about calls can be found [here](https://docs.persephony.com/reference/calls-1)

## Runnning the Tutorial

1. Run the application using command:

   ```bash
   $ dotnet run
   ```

