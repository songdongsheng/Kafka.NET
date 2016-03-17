using System;
using System.Collections.Generic;

namespace Kafka.NET
{
    public class Producer
    {
        public Producer(List<Uri> kafkaBootstrapBrokerList)
        {
        }

        public Producer(List<Uri> kafkaBootstrapBrokerList, ProducerConfig kafkaProducerConfig)
        {
        }

        public void Send(List<Message> message)
        {
        }

        public void Send(List<Message> message, SendCallback callback)
        {
        }

        public void Send(List<StringMessage> message)
        {
        }

        public void Send(List<StringMessage> message, SendCallback callback)
        {
        }
    }

    public delegate void SendCallback(Producer producer, List<Message> message, int resultCode);
}
