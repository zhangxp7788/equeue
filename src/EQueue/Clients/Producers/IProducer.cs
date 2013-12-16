﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EQueue.Common;

namespace EQueue.Clients.Producers
{
    public interface IProducer
    {
        string GroupName { get; }
        IEnumerable<string> PublishTopics { get; }
        void Start();
        void Shutdown();
        Task<SendResult> Send(Message message);
        bool IsPublishTopicNeedUpdate(string topic);
        void UpdateTopicPublishInfo(string topic, IEnumerable<MessageQueue> messageQueues);
    }
}