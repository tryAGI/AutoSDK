//HintName: G.Models.DatetimeExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatetimeExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datetime", Required = global::Newtonsoft.Json.Required.Always)]
        public string Datetime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeExpression" /> class.
        /// </summary>
        /// <param name="datetime"></param>
        public DatetimeExpression(
            string datetime)
        {
            this.Datetime = datetime ?? throw new global::System.ArgumentNullException(nameof(datetime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeExpression" /> class.
        /// </summary>
        public DatetimeExpression()
        {
        }
    }
}