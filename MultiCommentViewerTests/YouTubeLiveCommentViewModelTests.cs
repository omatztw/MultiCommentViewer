﻿using YouTubeLiveSitePlugin;
using Moq;
using MultiCommentViewer;
using NUnit.Framework;
using Plugin;
using SitePlugin;
using System.ComponentModel;

namespace MultiCommentViewerTests
{
    [TestFixture]
    class YouTubeLiveCommentViewModelTests
    {
        [Test]
        public void IsVisibleTest()
        {
            var messageMock = new Mock<IYouTubeLiveComment>();
            messageMock.Setup(m => m.Id).Returns("");
            var metadataMock = new Mock<IMessageMetadata>();
            var methodsMock = new Mock<IMessageMethods>();
            var connectionStatusMock = new Mock<IConnectionStatus>();
            var optionsMock = new Mock<IOptions>();

            var message = messageMock.Object;
            var metadata = metadataMock.Object;
            var methods = methodsMock.Object;
            var connectionStatus = connectionStatusMock.Object;
            var options = optionsMock.Object;

            var cvm = new McvYouTubeLiveCommentViewModel(message, metadata, methods, connectionStatus, options);
            var isVisible = false;
            cvm.PropertyChanged += (s, e) =>
            {
                switch (e.PropertyName)
                {
                    case nameof(metadata.IsVisible):
                        isVisible = cvm.IsVisible;
                        break;
                }
            };
            metadataMock.Setup(u => u.IsVisible).Returns(true);
            metadataMock.Raise(c => c.PropertyChanged += null, new PropertyChangedEventArgs(nameof(metadata.IsVisible)));
            Assert.IsTrue(isVisible);
        }
    }
}
