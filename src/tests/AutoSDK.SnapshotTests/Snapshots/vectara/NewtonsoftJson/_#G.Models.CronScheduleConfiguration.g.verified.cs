//HintName: G.Models.CronScheduleConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for cron-based schedule execution.
    /// </summary>
    public sealed partial class CronScheduleConfiguration
    {
        /// <summary>
        /// The type of schedule.<br/>
        /// Example: cron
        /// </summary>
        /// <example>cron</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CronScheduleConfigurationType Type { get; set; }

        /// <summary>
        /// Cron expression specifying when the schedule should execute.<br/>
        /// Uses standard 5-field cron format:<br/>
        /// ┌───────────── minute (0-59)<br/>
        /// │ ┌───────────── hour (0-23)<br/>
        /// │ │ ┌───────────── day of month (1-31)<br/>
        /// │ │ │ ┌───────────── month (1-12)<br/>
        /// │ │ │ │ ┌───────────── day of week (0-6, Sunday=0)<br/>
        /// │ │ │ │ │<br/>
        /// * * * * *<br/>
        /// Special characters:<br/>
        /// - * : Any value<br/>
        /// - , : List (e.g., "1,15" for 1st and 15th)<br/>
        /// - - : Range (e.g., "1-5" for Monday-Friday)<br/>
        /// - / : Step (e.g., "*/15" for every 15 units)<br/>
        /// Common examples:<br/>
        /// - "0 9 * * *": Every day at 9:00 AM<br/>
        /// - "0 9 * * 1-5": Weekdays at 9:00 AM<br/>
        /// - "*/15 * * * *": Every 15 minutes<br/>
        /// - "0 */6 * * *": Every 6 hours<br/>
        /// - "0 0 1 * *": First day of every month at midnight<br/>
        /// - "0 0 * * 0": Every Sunday at midnight<br/>
        /// Tool for testing: https://crontab.guru/<br/>
        /// Example: 0 9 * * *
        /// </summary>
        /// <example>0 9 * * *</example>
        [global::Newtonsoft.Json.JsonProperty("cron_expression", Required = global::Newtonsoft.Json.Required.Always)]
        public string CronExpression { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CronScheduleConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of schedule.<br/>
        /// Example: cron
        /// </param>
        /// <param name="cronExpression">
        /// Cron expression specifying when the schedule should execute.<br/>
        /// Uses standard 5-field cron format:<br/>
        /// ┌───────────── minute (0-59)<br/>
        /// │ ┌───────────── hour (0-23)<br/>
        /// │ │ ┌───────────── day of month (1-31)<br/>
        /// │ │ │ ┌───────────── month (1-12)<br/>
        /// │ │ │ │ ┌───────────── day of week (0-6, Sunday=0)<br/>
        /// │ │ │ │ │<br/>
        /// * * * * *<br/>
        /// Special characters:<br/>
        /// - * : Any value<br/>
        /// - , : List (e.g., "1,15" for 1st and 15th)<br/>
        /// - - : Range (e.g., "1-5" for Monday-Friday)<br/>
        /// - / : Step (e.g., "*/15" for every 15 units)<br/>
        /// Common examples:<br/>
        /// - "0 9 * * *": Every day at 9:00 AM<br/>
        /// - "0 9 * * 1-5": Weekdays at 9:00 AM<br/>
        /// - "*/15 * * * *": Every 15 minutes<br/>
        /// - "0 */6 * * *": Every 6 hours<br/>
        /// - "0 0 1 * *": First day of every month at midnight<br/>
        /// - "0 0 * * 0": Every Sunday at midnight<br/>
        /// Tool for testing: https://crontab.guru/<br/>
        /// Example: 0 9 * * *
        /// </param>
        public CronScheduleConfiguration(
            string cronExpression,
            global::G.CronScheduleConfigurationType type)
        {
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CronScheduleConfiguration" /> class.
        /// </summary>
        public CronScheduleConfiguration()
        {
        }
    }
}