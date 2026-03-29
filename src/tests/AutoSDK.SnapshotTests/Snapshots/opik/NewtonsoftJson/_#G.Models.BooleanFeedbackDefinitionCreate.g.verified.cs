//HintName: G.Models.BooleanFeedbackDefinitionCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFeedbackDefinitionCreate : global::G.FeedbackCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.BooleanFeedbackDetailCreate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="details"></param>
        public BooleanFeedbackDefinitionCreate(
            string name,
            global::G.BooleanFeedbackDetailCreate? details)
        {
            this.Details = details;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionCreate" /> class.
        /// </summary>
        public BooleanFeedbackDefinitionCreate()
        {
        }
    }
}