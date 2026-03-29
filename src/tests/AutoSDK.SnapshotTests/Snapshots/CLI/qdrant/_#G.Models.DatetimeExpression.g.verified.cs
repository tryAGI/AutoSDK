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
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Datetime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeExpression" /> class.
        /// </summary>
        /// <param name="datetime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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