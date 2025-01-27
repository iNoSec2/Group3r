using BigFish.Assessment;
using LibSnaffle.Classifiers.Results;
using LibSnaffle.Concurrency;
using System;

namespace BigFish.Concurrency
{
    public class GrouperMq : BlockingMq
    {
        public void GpoResult(GpoResult gpoResult, string messageText)
        {
            Q.Add(new GpoResultMessage
            {
                MsgDateTime = DateTime.Now,
                MessageString = messageText,
                GpoResult = gpoResult
            });
        }

        /// <summary>
        /// A file result message to handle snaffler output
        /// </summary>
        /// <param name="message"></param>
        /// <param name="result"></param>
        public void FileResult(string message, FileResult result)
        {
            Q.Add(new FileResultMessage
            {
                MsgDateTime = DateTime.Now,
                MessageString = message,
                Result = result
            });
        }

    }
}
