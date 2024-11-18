using TechTalk.SpecFlow;

namespace ApiLayer.Hooks
{
    [Binding]
    public class SpecflowHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Initialize any resources required before the test run
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // Clean up any resources used during the test run
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