//HintName: G.Models.ActionsEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `PROJECT_CREATED` - PROJECT_CREATED<br/>
    /// * `PROJECT_UPDATED` - PROJECT_UPDATED<br/>
    /// * `PROJECT_DELETED` - PROJECT_DELETED<br/>
    /// * `TASKS_CREATED` - TASKS_CREATED<br/>
    /// * `TASKS_DELETED` - TASKS_DELETED<br/>
    /// * `ANNOTATION_CREATED` - ANNOTATION_CREATED<br/>
    /// * `ANNOTATIONS_CREATED` - ANNOTATIONS_CREATED<br/>
    /// * `ANNOTATION_UPDATED` - ANNOTATION_UPDATED<br/>
    /// * `ANNOTATIONS_DELETED` - ANNOTATIONS_DELETED<br/>
    /// * `LABEL_LINK_CREATED` - LABEL_LINK_CREATED<br/>
    /// * `LABEL_LINK_UPDATED` - LABEL_LINK_UPDATED<br/>
    /// * `LABEL_LINK_DELETED` - LABEL_LINK_DELETED<br/>
    /// * `REVIEW_CREATED` - REVIEW_CREATED<br/>
    /// * `REVIEW_UPDATED` - REVIEW_UPDATED<br/>
    /// * `REVIEWS_DELETED` - REVIEWS_DELETED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATIONS_CREATED")]
        AnnotationsCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATIONS_DELETED")]
        AnnotationsDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATION_CREATED")]
        AnnotationCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATION_UPDATED")]
        AnnotationUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LABEL_LINK_CREATED")]
        LabelLinkCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LABEL_LINK_DELETED")]
        LabelLinkDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LABEL_LINK_UPDATED")]
        LabelLinkUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROJECT_CREATED")]
        ProjectCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROJECT_DELETED")]
        ProjectDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROJECT_UPDATED")]
        ProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REVIEWS_DELETED")]
        ReviewsDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REVIEW_CREATED")]
        ReviewCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REVIEW_UPDATED")]
        ReviewUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASKS_CREATED")]
        TasksCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASKS_DELETED")]
        TasksDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsEnum value)
        {
            return value switch
            {
                ActionsEnum.AnnotationsCreated => "ANNOTATIONS_CREATED",
                ActionsEnum.AnnotationsDeleted => "ANNOTATIONS_DELETED",
                ActionsEnum.AnnotationCreated => "ANNOTATION_CREATED",
                ActionsEnum.AnnotationUpdated => "ANNOTATION_UPDATED",
                ActionsEnum.LabelLinkCreated => "LABEL_LINK_CREATED",
                ActionsEnum.LabelLinkDeleted => "LABEL_LINK_DELETED",
                ActionsEnum.LabelLinkUpdated => "LABEL_LINK_UPDATED",
                ActionsEnum.ProjectCreated => "PROJECT_CREATED",
                ActionsEnum.ProjectDeleted => "PROJECT_DELETED",
                ActionsEnum.ProjectUpdated => "PROJECT_UPDATED",
                ActionsEnum.ReviewsDeleted => "REVIEWS_DELETED",
                ActionsEnum.ReviewCreated => "REVIEW_CREATED",
                ActionsEnum.ReviewUpdated => "REVIEW_UPDATED",
                ActionsEnum.TasksCreated => "TASKS_CREATED",
                ActionsEnum.TasksDeleted => "TASKS_DELETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsEnum? ToEnum(string value)
        {
            return value switch
            {
                "ANNOTATIONS_CREATED" => ActionsEnum.AnnotationsCreated,
                "ANNOTATIONS_DELETED" => ActionsEnum.AnnotationsDeleted,
                "ANNOTATION_CREATED" => ActionsEnum.AnnotationCreated,
                "ANNOTATION_UPDATED" => ActionsEnum.AnnotationUpdated,
                "LABEL_LINK_CREATED" => ActionsEnum.LabelLinkCreated,
                "LABEL_LINK_DELETED" => ActionsEnum.LabelLinkDeleted,
                "LABEL_LINK_UPDATED" => ActionsEnum.LabelLinkUpdated,
                "PROJECT_CREATED" => ActionsEnum.ProjectCreated,
                "PROJECT_DELETED" => ActionsEnum.ProjectDeleted,
                "PROJECT_UPDATED" => ActionsEnum.ProjectUpdated,
                "REVIEWS_DELETED" => ActionsEnum.ReviewsDeleted,
                "REVIEW_CREATED" => ActionsEnum.ReviewCreated,
                "REVIEW_UPDATED" => ActionsEnum.ReviewUpdated,
                "TASKS_CREATED" => ActionsEnum.TasksCreated,
                "TASKS_DELETED" => ActionsEnum.TasksDeleted,
                _ => null,
            };
        }
    }
}