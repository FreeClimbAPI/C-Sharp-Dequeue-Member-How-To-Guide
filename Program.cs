using System;
using com.freeclimb.api;
using com.freeclimb.api.queue;

namespace DequeueMember {
  class Program {
    static string getFreeClimbAccountId () {
      return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
    }

    static string getFreeClimbAccountToken () {
      return System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
    }

    static void Dequeue(string queueId, string callId = "") {
      // Create FreeClimbClient object
      FreeClimbClient client = new FreeClimbClient (getFreeClimbAccountId (),
        getFreeClimbAccountToken ());

      // Invoke method to update the QueueMeber to dequeue it from the queue
      QueueMember queueMember = client.getQueuesRequester.updateQueueMember(queueId, callId);

    }
    static void Main (string[] args) {
      string queueId = "";
      string callId = "";

      Dequeue(queueId, callId);
    }
  }
}