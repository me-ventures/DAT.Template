using DAT.EventBus;
using DAT.Template.Services;

namespace DAT.Template
{
    public class Handlers
    {
        private readonly IEventBus _eventBus;
        private readonly SampleService _service;

        public Handlers(IEventBus eventBus, SampleService service)
        {
            _eventBus = eventBus;
            _service = service;
        }
        
        public void Setup()
        {
            _eventBus.Subscribe<string>("test-event.test", s =>
            {
                _service.SampleFunction();
                return true;
            });       
        }
    }
}