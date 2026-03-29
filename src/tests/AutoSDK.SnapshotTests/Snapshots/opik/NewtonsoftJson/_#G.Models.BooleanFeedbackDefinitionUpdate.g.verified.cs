//HintName: G.Models.BooleanFeedbackDefinitionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFeedbackDefinitionUpdate : global::G.FeedbackUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.BooleanFeedbackDetailUpdate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="details"></param>
        public BooleanFeedbackDefinitionUpdate(
            string name,
            global::G.BooleanFeedbackDetailUpdate? details)
        {
            this.Details = details;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionUpdate" /> class.
        /// </summary>
        public BooleanFeedbackDefinitionUpdate()
        {
        }
    }
}