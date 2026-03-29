//HintName: G.Models.GitMetadataSettingsField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GitMetadataSettingsField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="author_email")]
        AuthorEmail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="author_name")]
        AuthorName,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch")]
        Branch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit")]
        Commit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_message")]
        CommitMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit_time")]
        CommitTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dirty")]
        Dirty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="git_diff")]
        GitDiff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GitMetadataSettingsFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitMetadataSettingsField value)
        {
            return value switch
            {
                GitMetadataSettingsField.AuthorEmail => "author_email",
                GitMetadataSettingsField.AuthorName => "author_name",
                GitMetadataSettingsField.Branch => "branch",
                GitMetadataSettingsField.Commit => "commit",
                GitMetadataSettingsField.CommitMessage => "commit_message",
                GitMetadataSettingsField.CommitTime => "commit_time",
                GitMetadataSettingsField.Dirty => "dirty",
                GitMetadataSettingsField.GitDiff => "git_diff",
                GitMetadataSettingsField.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitMetadataSettingsField? ToEnum(string value)
        {
            return value switch
            {
                "author_email" => GitMetadataSettingsField.AuthorEmail,
                "author_name" => GitMetadataSettingsField.AuthorName,
                "branch" => GitMetadataSettingsField.Branch,
                "commit" => GitMetadataSettingsField.Commit,
                "commit_message" => GitMetadataSettingsField.CommitMessage,
                "commit_time" => GitMetadataSettingsField.CommitTime,
                "dirty" => GitMetadataSettingsField.Dirty,
                "git_diff" => GitMetadataSettingsField.GitDiff,
                "tag" => GitMetadataSettingsField.Tag,
                _ => null,
            };
        }
    }
}