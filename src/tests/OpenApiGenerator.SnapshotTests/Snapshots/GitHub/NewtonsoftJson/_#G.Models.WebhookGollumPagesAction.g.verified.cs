//HintName: G.Models.WebhookGollumPagesAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action that was performed on the page. Can be `created` or `edited`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookGollumPagesAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="edited")]
        Edited,
    }
}