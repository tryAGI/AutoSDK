//HintName: G.Models.GetAvatars1Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatars1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatars", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.AllOf<global::G.GetAvatars1ResponseAvatarVariant1, object>?, global::G.GetAvatars1ResponseAvatar>> Avatars { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatars1Response" /> class.
        /// </summary>
        /// <param name="avatars"></param>
        public GetAvatars1Response(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.AllOf<global::G.GetAvatars1ResponseAvatarVariant1, object>?, global::G.GetAvatars1ResponseAvatar>> avatars)
        {
            this.Avatars = avatars ?? throw new global::System.ArgumentNullException(nameof(avatars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatars1Response" /> class.
        /// </summary>
        public GetAvatars1Response()
        {
        }
    }
}