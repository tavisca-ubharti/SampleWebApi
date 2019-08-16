using SampleWebApi.Controllers;
using System;
using Xunit;

namespace MessageRouterFixture.Tests
{
    public class MessageRouterFixture
    {
        private MessageRouter _messageRouter;

        public MessageRouterFixture()
        {
            _messageRouter = new MessageRouter();
        }

        [Fact]
        public void Send_hii_should_return_hello()
        {
            var resultFromCall = _messageRouter.Get("hii");
            Assert.Equal("Hello", resultFromCall);
        }

        [Fact]
        public void Send_hello_should_return_hii()
        {
            var resultFromCall = _messageRouter.Get("hello");
            Assert.Equal("Hii", resultFromCall);
        }
    }
}
