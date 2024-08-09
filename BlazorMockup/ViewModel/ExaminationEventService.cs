namespace BlazorMockup.ViewModel
{
    public class ExaminationEventService
    {
        public event EventHandler ExaminationSaved;

        public void NotifyExaminationSaved()
        {
            ExaminationSaved?.Invoke(this, EventArgs.Empty);
        }
    }
}
