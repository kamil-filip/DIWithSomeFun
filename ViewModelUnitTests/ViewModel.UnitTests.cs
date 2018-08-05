using NUnit.Framework;
using Moq;
using Repository.Interface;
using ViewModel;

namespace ViewModelUnitTests
{
    [TestFixture]
    public class ViewModelUnitTests
    {

        private IRepository _repository;

        [SetUp]
        public void Setup()
        {
            var repositoryStub = new Mock<IRepository>();
            repositoryStub.Setup(it => it.Get()).Returns("ValidMsg");
            _repository = repositoryStub.Object;
        }

        [Test]
        public void ViewModel_OnLoad_ReturnsValidMessage()
        {
            var vm = new MyViewModel(_repository);

            vm.Load();

            Assert.AreEqual("ValidMsg", vm.OutputMessage);
        }


        [Test]
        public void ViewModel_OnRefresh_ClearErrorMessage()
        {
            var vm = new MyViewModel(_repository);

            vm.Refresh();

            Assert.AreEqual("", vm.OutputMessage);
        }
    }
}
