﻿using System;
using io.iron.ironmq;

namespace _01.IronMQApp
{
    class MessageSender
    {
        static void Main(string[] args)
        {
            Client client = new Client("520f706527c7200005000001", "JySHBhogfvbKpQ8I5CkUFoY-FnI");

            Queue queue = client.queue("ChatQueue");

            Console.WriteLine("Send messages:");

            while (true)
            {
                string msg = Console.ReadLine();
                queue.push(msg);
                Console.WriteLine("Message sent to IronMQ server.");
            }
        }
    }
}
