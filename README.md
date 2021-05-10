# C# - Dequeue a Member Tutorial

This project serves as a guide to help you build an application with FreeClimb. View this tutorial on [FreeClimb.com](https://docs.freeclimb.com/docs/dequeue-member-1#section-c). Specifically, the project will:

- Remove a call from a call queue and interact with the dequeue call

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://docs.freeclimb.com/docs/getting-started-with-freeclimb).

## Setting up the Tutorial

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb-cs-sdk
   ```

2. Configure environment variables

   | ENV VARIABLE            | DESCRIPTION                                                                                                                                                                             |
   | ----------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
   | ACCOUNT_ID              | Account ID which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard                                                         |
   | API_KEY              | API key which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard                                               |

3. Provide a value for the variables `queueuId` and `callId`. More about queues can be found [here](https://docs.freeclimb.com/reference/queues-1) and more about calls can be found [here](https://docs.freeclimb.com/reference/calls-1)

## Runnning the Tutorial

1. Run the application using command:

   ```bash
   $ dotnet run
   ```

## Getting Help

If you are experiencing difficulties, [contact support](https://freeclimb.com/support).
