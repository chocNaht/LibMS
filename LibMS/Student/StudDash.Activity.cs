namespace LibMS
{
    public partial class StudDash
    {
        private void btnAllAct_Click(
    object sender,
    EventArgs e)
        {
            DisplayActivityLogs(
                _activityLogs);
        }

        private void btnBor_Click(
    object sender,
    EventArgs e)
        {
            var borrowed =
                _activityLogs
                    .Where(x =>
                        x.Status == "Borrowed")
                    .ToList();

            DisplayActivityLogs(
                borrowed);
        }

        private void btnRet_Click(
    object sender,
    EventArgs e)
        {
            var returned =
                _activityLogs
                    .Where(x =>
                        x.Status == "Returned")
                    .ToList();

            DisplayActivityLogs(
                returned);
        }
    }
}