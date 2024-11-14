using TechTalk.SpecFlow;

namespace ApiLayer.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Setup code before any tests are run
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // Cleanup code after all tests are run
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Code to execute before each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Code to execute after each scenario
        }
    }
}