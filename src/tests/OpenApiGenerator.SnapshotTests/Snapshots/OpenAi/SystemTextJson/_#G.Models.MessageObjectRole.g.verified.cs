//HintName: G.Models.MessageObjectRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entity that produced the message. One of `user` or `assistant`.
    /// </summary>
    public abstract class MessageObjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        public const string User = "user";
        /// <summary>
        /// 
        /// </summary>
        public const string Assistant = "assistant";
    }
}