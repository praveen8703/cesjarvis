using System;
using System.Collections.Generic;
using System.Text;

namespace CesJarvis.Models.Request
{
    public class RequestBody
    {
        public string lang { get; set; }
        public Status status { get; set; }
        public DateTime timestamp { get; set; }
        public string sessionId { get; set; }
        public Result result { get; set; }
        public string id { get; set; }
        public Originalrequest originalRequest { get; set; }
    }

    public class Status
    {
        public string errorType { get; set; }
        public int code { get; set; }
    }

    public class Result
    {
        public Parameters parameters { get; set; }
        public object[] contexts { get; set; }
        public string resolvedQuery { get; set; }
        public string source { get; set; }
        public float score { get; set; }
        public string speech { get; set; }
        public Fulfillment fulfillment { get; set; }
        public bool actionIncomplete { get; set; }
        public string action { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Parameters
    {
        public string city { get; set; }
        public string name { get; set; }
    }

    public class Fulfillment
    {
        public Message[] messages { get; set; }
        public string speech { get; set; }
    }

    public class Message
    {
        public string speech { get; set; }
        public int type { get; set; }
    }

    public class Metadata
    {
        public string intentId { get; set; }
        public string webhookForSlotFillingUsed { get; set; }
        public string intentName { get; set; }
        public string webhookUsed { get; set; }
    }

    public class Originalrequest
    {
        public string source { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Input[] inputs { get; set; }
        public User user { get; set; }
        public Conversation conversation { get; set; }
    }

    public class User
    {
        public string user_id { get; set; }
    }

    public class Conversation
    {
        public string conversation_id { get; set; }
        public int type { get; set; }
        public string conversation_token { get; set; }
    }

    public class Input
    {
        public Raw_Inputs[] raw_inputs { get; set; }
        public string intent { get; set; }
        public Argument[] arguments { get; set; }
    }

    public class Raw_Inputs
    {
        public string query { get; set; }
        public int input_type { get; set; }
    }

    public class Argument
    {
        public string text_value { get; set; }
        public string raw_text { get; set; }
        public string name { get; set; }
    }
}
