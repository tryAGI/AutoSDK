//HintName: G.Models.CountValueStatPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountValueStatPublic : global::G.ProjectStatItemObjectPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public long? Value { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CountValueStatPublic" /> class.
        /// </summary>
        /// <param name="value"></param>
        public CountValueStatPublic(
            long? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountValueStatPublic" /> class.
        /// </summary>
        public CountValueStatPublic()
        {
        }
    }
}