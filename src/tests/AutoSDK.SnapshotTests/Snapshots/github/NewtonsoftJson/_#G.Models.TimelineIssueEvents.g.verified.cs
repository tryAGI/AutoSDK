//HintName: G.Models.TimelineIssueEvents.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Event
    /// </summary>
    public readonly partial struct TimelineIssueEvents : global::System.IEquatable<TimelineIssueEvents>
    {
        /// <summary>
        /// Labeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LabeledIssueEvent? LabeledIssueEvent { get; init; }
#else
        public global::G.LabeledIssueEvent? LabeledIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabeledIssueEvent))]
#endif
        public bool IsLabeledIssueEvent => LabeledIssueEvent != null;

        /// <summary>
        /// Unlabeled Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UnlabeledIssueEvent? UnlabeledIssueEvent { get; init; }
#else
        public global::G.UnlabeledIssueEvent? UnlabeledIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnlabeledIssueEvent))]
#endif
        public bool IsUnlabeledIssueEvent => UnlabeledIssueEvent != null;

        /// <summary>
        /// Milestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MilestonedIssueEvent? MilestonedIssueEvent { get; init; }
#else
        public global::G.MilestonedIssueEvent? MilestonedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MilestonedIssueEvent))]
#endif
        public bool IsMilestonedIssueEvent => MilestonedIssueEvent != null;

        /// <summary>
        /// Demilestoned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DemilestonedIssueEvent? DemilestonedIssueEvent { get; init; }
#else
        public global::G.DemilestonedIssueEvent? DemilestonedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DemilestonedIssueEvent))]
#endif
        public bool IsDemilestonedIssueEvent => DemilestonedIssueEvent != null;

        /// <summary>
        /// Renamed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RenamedIssueEvent? RenamedIssueEvent { get; init; }
#else
        public global::G.RenamedIssueEvent? RenamedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RenamedIssueEvent))]
#endif
        public bool IsRenamedIssueEvent => RenamedIssueEvent != null;

        /// <summary>
        /// Review Requested Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; init; }
#else
        public global::G.ReviewRequestedIssueEvent? ReviewRequestedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestedIssueEvent))]
#endif
        public bool IsReviewRequestedIssueEvent => ReviewRequestedIssueEvent != null;

        /// <summary>
        /// Review Request Removed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; init; }
#else
        public global::G.ReviewRequestRemovedIssueEvent? ReviewRequestRemovedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewRequestRemovedIssueEvent))]
#endif
        public bool IsReviewRequestRemovedIssueEvent => ReviewRequestRemovedIssueEvent != null;

        /// <summary>
        /// Review Dismissed Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; init; }
#else
        public global::G.ReviewDismissedIssueEvent? ReviewDismissedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewDismissedIssueEvent))]
#endif
        public bool IsReviewDismissedIssueEvent => ReviewDismissedIssueEvent != null;

        /// <summary>
        /// Locked Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LockedIssueEvent? LockedIssueEvent { get; init; }
#else
        public global::G.LockedIssueEvent? LockedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LockedIssueEvent))]
#endif
        public bool IsLockedIssueEvent => LockedIssueEvent != null;

        /// <summary>
        /// Added to Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; init; }
#else
        public global::G.AddedToProjectIssueEvent? AddedToProjectIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddedToProjectIssueEvent))]
#endif
        public bool IsAddedToProjectIssueEvent => AddedToProjectIssueEvent != null;

        /// <summary>
        /// Moved Column in Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; init; }
#else
        public global::G.MovedColumnInProjectIssueEvent? MovedColumnInProjectIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MovedColumnInProjectIssueEvent))]
#endif
        public bool IsMovedColumnInProjectIssueEvent => MovedColumnInProjectIssueEvent != null;

        /// <summary>
        /// Removed from Project Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; init; }
#else
        public global::G.RemovedFromProjectIssueEvent? RemovedFromProjectIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemovedFromProjectIssueEvent))]
#endif
        public bool IsRemovedFromProjectIssueEvent => RemovedFromProjectIssueEvent != null;

        /// <summary>
        /// Converted Note to Issue Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; init; }
#else
        public global::G.ConvertedNoteToIssueIssueEvent? ConvertedNoteToIssueIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConvertedNoteToIssueIssueEvent))]
#endif
        public bool IsConvertedNoteToIssueIssueEvent => ConvertedNoteToIssueIssueEvent != null;

        /// <summary>
        /// Timeline Comment Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCommentEvent? TimelineCommentEvent { get; init; }
#else
        public global::G.TimelineCommentEvent? TimelineCommentEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCommentEvent))]
#endif
        public bool IsTimelineCommentEvent => TimelineCommentEvent != null;

        /// <summary>
        /// Timeline Cross Referenced Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCrossReferencedEvent? TimelineCrossReferencedEvent { get; init; }
#else
        public global::G.TimelineCrossReferencedEvent? TimelineCrossReferencedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCrossReferencedEvent))]
#endif
        public bool IsTimelineCrossReferencedEvent => TimelineCrossReferencedEvent != null;

        /// <summary>
        /// Timeline Committed Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCommittedEvent? TimelineCommittedEvent { get; init; }
#else
        public global::G.TimelineCommittedEvent? TimelineCommittedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCommittedEvent))]
#endif
        public bool IsTimelineCommittedEvent => TimelineCommittedEvent != null;

        /// <summary>
        /// Timeline Reviewed Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineReviewedEvent? TimelineReviewedEvent { get; init; }
#else
        public global::G.TimelineReviewedEvent? TimelineReviewedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineReviewedEvent))]
#endif
        public bool IsTimelineReviewedEvent => TimelineReviewedEvent != null;

        /// <summary>
        /// Timeline Line Commented Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineLineCommentedEvent? TimelineLineCommentedEvent { get; init; }
#else
        public global::G.TimelineLineCommentedEvent? TimelineLineCommentedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineLineCommentedEvent))]
#endif
        public bool IsTimelineLineCommentedEvent => TimelineLineCommentedEvent != null;

        /// <summary>
        /// Timeline Commit Commented Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineCommitCommentedEvent? TimelineCommitCommentedEvent { get; init; }
#else
        public global::G.TimelineCommitCommentedEvent? TimelineCommitCommentedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineCommitCommentedEvent))]
#endif
        public bool IsTimelineCommitCommentedEvent => TimelineCommitCommentedEvent != null;

        /// <summary>
        /// Timeline Assigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineAssignedIssueEvent? TimelineAssignedIssueEvent { get; init; }
#else
        public global::G.TimelineAssignedIssueEvent? TimelineAssignedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineAssignedIssueEvent))]
#endif
        public bool IsTimelineAssignedIssueEvent => TimelineAssignedIssueEvent != null;

        /// <summary>
        /// Timeline Unassigned Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TimelineUnassignedIssueEvent? TimelineUnassignedIssueEvent { get; init; }
#else
        public global::G.TimelineUnassignedIssueEvent? TimelineUnassignedIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimelineUnassignedIssueEvent))]
#endif
        public bool IsTimelineUnassignedIssueEvent => TimelineUnassignedIssueEvent != null;

        /// <summary>
        /// State Change Issue Event
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StateChangeIssueEvent? StateChangeIssueEvent { get; init; }
#else
        public global::G.StateChangeIssueEvent? StateChangeIssueEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StateChangeIssueEvent))]
#endif
        public bool IsStateChangeIssueEvent => StateChangeIssueEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.LabeledIssueEvent value) => new TimelineIssueEvents((global::G.LabeledIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LabeledIssueEvent?(TimelineIssueEvents @this) => @this.LabeledIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.LabeledIssueEvent? value)
        {
            LabeledIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.UnlabeledIssueEvent value) => new TimelineIssueEvents((global::G.UnlabeledIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UnlabeledIssueEvent?(TimelineIssueEvents @this) => @this.UnlabeledIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.UnlabeledIssueEvent? value)
        {
            UnlabeledIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.MilestonedIssueEvent value) => new TimelineIssueEvents((global::G.MilestonedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MilestonedIssueEvent?(TimelineIssueEvents @this) => @this.MilestonedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.MilestonedIssueEvent? value)
        {
            MilestonedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.DemilestonedIssueEvent value) => new TimelineIssueEvents((global::G.DemilestonedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DemilestonedIssueEvent?(TimelineIssueEvents @this) => @this.DemilestonedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.DemilestonedIssueEvent? value)
        {
            DemilestonedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.RenamedIssueEvent value) => new TimelineIssueEvents((global::G.RenamedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RenamedIssueEvent?(TimelineIssueEvents @this) => @this.RenamedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.RenamedIssueEvent? value)
        {
            RenamedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ReviewRequestedIssueEvent value) => new TimelineIssueEvents((global::G.ReviewRequestedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ReviewRequestedIssueEvent? value)
        {
            ReviewRequestedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ReviewRequestRemovedIssueEvent value) => new TimelineIssueEvents((global::G.ReviewRequestRemovedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewRequestRemovedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewRequestRemovedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ReviewRequestRemovedIssueEvent? value)
        {
            ReviewRequestRemovedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ReviewDismissedIssueEvent value) => new TimelineIssueEvents((global::G.ReviewDismissedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReviewDismissedIssueEvent?(TimelineIssueEvents @this) => @this.ReviewDismissedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ReviewDismissedIssueEvent? value)
        {
            ReviewDismissedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.LockedIssueEvent value) => new TimelineIssueEvents((global::G.LockedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LockedIssueEvent?(TimelineIssueEvents @this) => @this.LockedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.LockedIssueEvent? value)
        {
            LockedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.AddedToProjectIssueEvent value) => new TimelineIssueEvents((global::G.AddedToProjectIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AddedToProjectIssueEvent?(TimelineIssueEvents @this) => @this.AddedToProjectIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.AddedToProjectIssueEvent? value)
        {
            AddedToProjectIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.MovedColumnInProjectIssueEvent value) => new TimelineIssueEvents((global::G.MovedColumnInProjectIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MovedColumnInProjectIssueEvent?(TimelineIssueEvents @this) => @this.MovedColumnInProjectIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.MovedColumnInProjectIssueEvent? value)
        {
            MovedColumnInProjectIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.RemovedFromProjectIssueEvent value) => new TimelineIssueEvents((global::G.RemovedFromProjectIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RemovedFromProjectIssueEvent?(TimelineIssueEvents @this) => @this.RemovedFromProjectIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.RemovedFromProjectIssueEvent? value)
        {
            RemovedFromProjectIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.ConvertedNoteToIssueIssueEvent value) => new TimelineIssueEvents((global::G.ConvertedNoteToIssueIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConvertedNoteToIssueIssueEvent?(TimelineIssueEvents @this) => @this.ConvertedNoteToIssueIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.ConvertedNoteToIssueIssueEvent? value)
        {
            ConvertedNoteToIssueIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCommentEvent value) => new TimelineIssueEvents((global::G.TimelineCommentEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCommentEvent?(TimelineIssueEvents @this) => @this.TimelineCommentEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCommentEvent? value)
        {
            TimelineCommentEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCrossReferencedEvent value) => new TimelineIssueEvents((global::G.TimelineCrossReferencedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCrossReferencedEvent?(TimelineIssueEvents @this) => @this.TimelineCrossReferencedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCrossReferencedEvent? value)
        {
            TimelineCrossReferencedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCommittedEvent value) => new TimelineIssueEvents((global::G.TimelineCommittedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCommittedEvent?(TimelineIssueEvents @this) => @this.TimelineCommittedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCommittedEvent? value)
        {
            TimelineCommittedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineReviewedEvent value) => new TimelineIssueEvents((global::G.TimelineReviewedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineReviewedEvent?(TimelineIssueEvents @this) => @this.TimelineReviewedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineReviewedEvent? value)
        {
            TimelineReviewedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineLineCommentedEvent value) => new TimelineIssueEvents((global::G.TimelineLineCommentedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineLineCommentedEvent?(TimelineIssueEvents @this) => @this.TimelineLineCommentedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineLineCommentedEvent? value)
        {
            TimelineLineCommentedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineCommitCommentedEvent value) => new TimelineIssueEvents((global::G.TimelineCommitCommentedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineCommitCommentedEvent?(TimelineIssueEvents @this) => @this.TimelineCommitCommentedEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineCommitCommentedEvent? value)
        {
            TimelineCommitCommentedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineAssignedIssueEvent value) => new TimelineIssueEvents((global::G.TimelineAssignedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineAssignedIssueEvent?(TimelineIssueEvents @this) => @this.TimelineAssignedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineAssignedIssueEvent? value)
        {
            TimelineAssignedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.TimelineUnassignedIssueEvent value) => new TimelineIssueEvents((global::G.TimelineUnassignedIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TimelineUnassignedIssueEvent?(TimelineIssueEvents @this) => @this.TimelineUnassignedIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.TimelineUnassignedIssueEvent? value)
        {
            TimelineUnassignedIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TimelineIssueEvents(global::G.StateChangeIssueEvent value) => new TimelineIssueEvents((global::G.StateChangeIssueEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StateChangeIssueEvent?(TimelineIssueEvents @this) => @this.StateChangeIssueEvent;

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(global::G.StateChangeIssueEvent? value)
        {
            StateChangeIssueEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TimelineIssueEvents(
            global::G.LabeledIssueEvent? labeledIssueEvent,
            global::G.UnlabeledIssueEvent? unlabeledIssueEvent,
            global::G.MilestonedIssueEvent? milestonedIssueEvent,
            global::G.DemilestonedIssueEvent? demilestonedIssueEvent,
            global::G.RenamedIssueEvent? renamedIssueEvent,
            global::G.ReviewRequestedIssueEvent? reviewRequestedIssueEvent,
            global::G.ReviewRequestRemovedIssueEvent? reviewRequestRemovedIssueEvent,
            global::G.ReviewDismissedIssueEvent? reviewDismissedIssueEvent,
            global::G.LockedIssueEvent? lockedIssueEvent,
            global::G.AddedToProjectIssueEvent? addedToProjectIssueEvent,
            global::G.MovedColumnInProjectIssueEvent? movedColumnInProjectIssueEvent,
            global::G.RemovedFromProjectIssueEvent? removedFromProjectIssueEvent,
            global::G.ConvertedNoteToIssueIssueEvent? convertedNoteToIssueIssueEvent,
            global::G.TimelineCommentEvent? timelineCommentEvent,
            global::G.TimelineCrossReferencedEvent? timelineCrossReferencedEvent,
            global::G.TimelineCommittedEvent? timelineCommittedEvent,
            global::G.TimelineReviewedEvent? timelineReviewedEvent,
            global::G.TimelineLineCommentedEvent? timelineLineCommentedEvent,
            global::G.TimelineCommitCommentedEvent? timelineCommitCommentedEvent,
            global::G.TimelineAssignedIssueEvent? timelineAssignedIssueEvent,
            global::G.TimelineUnassignedIssueEvent? timelineUnassignedIssueEvent,
            global::G.StateChangeIssueEvent? stateChangeIssueEvent
            )
        {
            LabeledIssueEvent = labeledIssueEvent;
            UnlabeledIssueEvent = unlabeledIssueEvent;
            MilestonedIssueEvent = milestonedIssueEvent;
            DemilestonedIssueEvent = demilestonedIssueEvent;
            RenamedIssueEvent = renamedIssueEvent;
            ReviewRequestedIssueEvent = reviewRequestedIssueEvent;
            ReviewRequestRemovedIssueEvent = reviewRequestRemovedIssueEvent;
            ReviewDismissedIssueEvent = reviewDismissedIssueEvent;
            LockedIssueEvent = lockedIssueEvent;
            AddedToProjectIssueEvent = addedToProjectIssueEvent;
            MovedColumnInProjectIssueEvent = movedColumnInProjectIssueEvent;
            RemovedFromProjectIssueEvent = removedFromProjectIssueEvent;
            ConvertedNoteToIssueIssueEvent = convertedNoteToIssueIssueEvent;
            TimelineCommentEvent = timelineCommentEvent;
            TimelineCrossReferencedEvent = timelineCrossReferencedEvent;
            TimelineCommittedEvent = timelineCommittedEvent;
            TimelineReviewedEvent = timelineReviewedEvent;
            TimelineLineCommentedEvent = timelineLineCommentedEvent;
            TimelineCommitCommentedEvent = timelineCommitCommentedEvent;
            TimelineAssignedIssueEvent = timelineAssignedIssueEvent;
            TimelineUnassignedIssueEvent = timelineUnassignedIssueEvent;
            StateChangeIssueEvent = stateChangeIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StateChangeIssueEvent as object ??
            TimelineUnassignedIssueEvent as object ??
            TimelineAssignedIssueEvent as object ??
            TimelineCommitCommentedEvent as object ??
            TimelineLineCommentedEvent as object ??
            TimelineReviewedEvent as object ??
            TimelineCommittedEvent as object ??
            TimelineCrossReferencedEvent as object ??
            TimelineCommentEvent as object ??
            ConvertedNoteToIssueIssueEvent as object ??
            RemovedFromProjectIssueEvent as object ??
            MovedColumnInProjectIssueEvent as object ??
            AddedToProjectIssueEvent as object ??
            LockedIssueEvent as object ??
            ReviewDismissedIssueEvent as object ??
            ReviewRequestRemovedIssueEvent as object ??
            ReviewRequestedIssueEvent as object ??
            RenamedIssueEvent as object ??
            DemilestonedIssueEvent as object ??
            MilestonedIssueEvent as object ??
            UnlabeledIssueEvent as object ??
            LabeledIssueEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LabeledIssueEvent?.ToString() ??
            UnlabeledIssueEvent?.ToString() ??
            MilestonedIssueEvent?.ToString() ??
            DemilestonedIssueEvent?.ToString() ??
            RenamedIssueEvent?.ToString() ??
            ReviewRequestedIssueEvent?.ToString() ??
            ReviewRequestRemovedIssueEvent?.ToString() ??
            ReviewDismissedIssueEvent?.ToString() ??
            LockedIssueEvent?.ToString() ??
            AddedToProjectIssueEvent?.ToString() ??
            MovedColumnInProjectIssueEvent?.ToString() ??
            RemovedFromProjectIssueEvent?.ToString() ??
            ConvertedNoteToIssueIssueEvent?.ToString() ??
            TimelineCommentEvent?.ToString() ??
            TimelineCrossReferencedEvent?.ToString() ??
            TimelineCommittedEvent?.ToString() ??
            TimelineReviewedEvent?.ToString() ??
            TimelineLineCommentedEvent?.ToString() ??
            TimelineCommitCommentedEvent?.ToString() ??
            TimelineAssignedIssueEvent?.ToString() ??
            TimelineUnassignedIssueEvent?.ToString() ??
            StateChangeIssueEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLabeledIssueEvent || IsUnlabeledIssueEvent || IsMilestonedIssueEvent || IsDemilestonedIssueEvent || IsRenamedIssueEvent || IsReviewRequestedIssueEvent || IsReviewRequestRemovedIssueEvent || IsReviewDismissedIssueEvent || IsLockedIssueEvent || IsAddedToProjectIssueEvent || IsMovedColumnInProjectIssueEvent || IsRemovedFromProjectIssueEvent || IsConvertedNoteToIssueIssueEvent || IsTimelineCommentEvent || IsTimelineCrossReferencedEvent || IsTimelineCommittedEvent || IsTimelineReviewedEvent || IsTimelineLineCommentedEvent || IsTimelineCommitCommentedEvent || IsTimelineAssignedIssueEvent || IsTimelineUnassignedIssueEvent || IsStateChangeIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LabeledIssueEvent?, TResult>? labeledIssueEvent = null,
            global::System.Func<global::G.UnlabeledIssueEvent?, TResult>? unlabeledIssueEvent = null,
            global::System.Func<global::G.MilestonedIssueEvent?, TResult>? milestonedIssueEvent = null,
            global::System.Func<global::G.DemilestonedIssueEvent?, TResult>? demilestonedIssueEvent = null,
            global::System.Func<global::G.RenamedIssueEvent?, TResult>? renamedIssueEvent = null,
            global::System.Func<global::G.ReviewRequestedIssueEvent?, TResult>? reviewRequestedIssueEvent = null,
            global::System.Func<global::G.ReviewRequestRemovedIssueEvent?, TResult>? reviewRequestRemovedIssueEvent = null,
            global::System.Func<global::G.ReviewDismissedIssueEvent?, TResult>? reviewDismissedIssueEvent = null,
            global::System.Func<global::G.LockedIssueEvent?, TResult>? lockedIssueEvent = null,
            global::System.Func<global::G.AddedToProjectIssueEvent?, TResult>? addedToProjectIssueEvent = null,
            global::System.Func<global::G.MovedColumnInProjectIssueEvent?, TResult>? movedColumnInProjectIssueEvent = null,
            global::System.Func<global::G.RemovedFromProjectIssueEvent?, TResult>? removedFromProjectIssueEvent = null,
            global::System.Func<global::G.ConvertedNoteToIssueIssueEvent?, TResult>? convertedNoteToIssueIssueEvent = null,
            global::System.Func<global::G.TimelineCommentEvent?, TResult>? timelineCommentEvent = null,
            global::System.Func<global::G.TimelineCrossReferencedEvent?, TResult>? timelineCrossReferencedEvent = null,
            global::System.Func<global::G.TimelineCommittedEvent?, TResult>? timelineCommittedEvent = null,
            global::System.Func<global::G.TimelineReviewedEvent?, TResult>? timelineReviewedEvent = null,
            global::System.Func<global::G.TimelineLineCommentedEvent?, TResult>? timelineLineCommentedEvent = null,
            global::System.Func<global::G.TimelineCommitCommentedEvent?, TResult>? timelineCommitCommentedEvent = null,
            global::System.Func<global::G.TimelineAssignedIssueEvent?, TResult>? timelineAssignedIssueEvent = null,
            global::System.Func<global::G.TimelineUnassignedIssueEvent?, TResult>? timelineUnassignedIssueEvent = null,
            global::System.Func<global::G.StateChangeIssueEvent?, TResult>? stateChangeIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent && labeledIssueEvent != null)
            {
                return labeledIssueEvent(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent && unlabeledIssueEvent != null)
            {
                return unlabeledIssueEvent(UnlabeledIssueEvent!);
            }
            else if (IsMilestonedIssueEvent && milestonedIssueEvent != null)
            {
                return milestonedIssueEvent(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent && demilestonedIssueEvent != null)
            {
                return demilestonedIssueEvent(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent && renamedIssueEvent != null)
            {
                return renamedIssueEvent(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent && reviewRequestedIssueEvent != null)
            {
                return reviewRequestedIssueEvent(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent && reviewRequestRemovedIssueEvent != null)
            {
                return reviewRequestRemovedIssueEvent(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent && reviewDismissedIssueEvent != null)
            {
                return reviewDismissedIssueEvent(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent && lockedIssueEvent != null)
            {
                return lockedIssueEvent(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent && addedToProjectIssueEvent != null)
            {
                return addedToProjectIssueEvent(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent && movedColumnInProjectIssueEvent != null)
            {
                return movedColumnInProjectIssueEvent(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent && removedFromProjectIssueEvent != null)
            {
                return removedFromProjectIssueEvent(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent && convertedNoteToIssueIssueEvent != null)
            {
                return convertedNoteToIssueIssueEvent(ConvertedNoteToIssueIssueEvent!);
            }
            else if (IsTimelineCommentEvent && timelineCommentEvent != null)
            {
                return timelineCommentEvent(TimelineCommentEvent!);
            }
            else if (IsTimelineCrossReferencedEvent && timelineCrossReferencedEvent != null)
            {
                return timelineCrossReferencedEvent(TimelineCrossReferencedEvent!);
            }
            else if (IsTimelineCommittedEvent && timelineCommittedEvent != null)
            {
                return timelineCommittedEvent(TimelineCommittedEvent!);
            }
            else if (IsTimelineReviewedEvent && timelineReviewedEvent != null)
            {
                return timelineReviewedEvent(TimelineReviewedEvent!);
            }
            else if (IsTimelineLineCommentedEvent && timelineLineCommentedEvent != null)
            {
                return timelineLineCommentedEvent(TimelineLineCommentedEvent!);
            }
            else if (IsTimelineCommitCommentedEvent && timelineCommitCommentedEvent != null)
            {
                return timelineCommitCommentedEvent(TimelineCommitCommentedEvent!);
            }
            else if (IsTimelineAssignedIssueEvent && timelineAssignedIssueEvent != null)
            {
                return timelineAssignedIssueEvent(TimelineAssignedIssueEvent!);
            }
            else if (IsTimelineUnassignedIssueEvent && timelineUnassignedIssueEvent != null)
            {
                return timelineUnassignedIssueEvent(TimelineUnassignedIssueEvent!);
            }
            else if (IsStateChangeIssueEvent && stateChangeIssueEvent != null)
            {
                return stateChangeIssueEvent(StateChangeIssueEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LabeledIssueEvent?>? labeledIssueEvent = null,
            global::System.Action<global::G.UnlabeledIssueEvent?>? unlabeledIssueEvent = null,
            global::System.Action<global::G.MilestonedIssueEvent?>? milestonedIssueEvent = null,
            global::System.Action<global::G.DemilestonedIssueEvent?>? demilestonedIssueEvent = null,
            global::System.Action<global::G.RenamedIssueEvent?>? renamedIssueEvent = null,
            global::System.Action<global::G.ReviewRequestedIssueEvent?>? reviewRequestedIssueEvent = null,
            global::System.Action<global::G.ReviewRequestRemovedIssueEvent?>? reviewRequestRemovedIssueEvent = null,
            global::System.Action<global::G.ReviewDismissedIssueEvent?>? reviewDismissedIssueEvent = null,
            global::System.Action<global::G.LockedIssueEvent?>? lockedIssueEvent = null,
            global::System.Action<global::G.AddedToProjectIssueEvent?>? addedToProjectIssueEvent = null,
            global::System.Action<global::G.MovedColumnInProjectIssueEvent?>? movedColumnInProjectIssueEvent = null,
            global::System.Action<global::G.RemovedFromProjectIssueEvent?>? removedFromProjectIssueEvent = null,
            global::System.Action<global::G.ConvertedNoteToIssueIssueEvent?>? convertedNoteToIssueIssueEvent = null,
            global::System.Action<global::G.TimelineCommentEvent?>? timelineCommentEvent = null,
            global::System.Action<global::G.TimelineCrossReferencedEvent?>? timelineCrossReferencedEvent = null,
            global::System.Action<global::G.TimelineCommittedEvent?>? timelineCommittedEvent = null,
            global::System.Action<global::G.TimelineReviewedEvent?>? timelineReviewedEvent = null,
            global::System.Action<global::G.TimelineLineCommentedEvent?>? timelineLineCommentedEvent = null,
            global::System.Action<global::G.TimelineCommitCommentedEvent?>? timelineCommitCommentedEvent = null,
            global::System.Action<global::G.TimelineAssignedIssueEvent?>? timelineAssignedIssueEvent = null,
            global::System.Action<global::G.TimelineUnassignedIssueEvent?>? timelineUnassignedIssueEvent = null,
            global::System.Action<global::G.StateChangeIssueEvent?>? stateChangeIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabeledIssueEvent)
            {
                labeledIssueEvent?.Invoke(LabeledIssueEvent!);
            }
            else if (IsUnlabeledIssueEvent)
            {
                unlabeledIssueEvent?.Invoke(UnlabeledIssueEvent!);
            }
            else if (IsMilestonedIssueEvent)
            {
                milestonedIssueEvent?.Invoke(MilestonedIssueEvent!);
            }
            else if (IsDemilestonedIssueEvent)
            {
                demilestonedIssueEvent?.Invoke(DemilestonedIssueEvent!);
            }
            else if (IsRenamedIssueEvent)
            {
                renamedIssueEvent?.Invoke(RenamedIssueEvent!);
            }
            else if (IsReviewRequestedIssueEvent)
            {
                reviewRequestedIssueEvent?.Invoke(ReviewRequestedIssueEvent!);
            }
            else if (IsReviewRequestRemovedIssueEvent)
            {
                reviewRequestRemovedIssueEvent?.Invoke(ReviewRequestRemovedIssueEvent!);
            }
            else if (IsReviewDismissedIssueEvent)
            {
                reviewDismissedIssueEvent?.Invoke(ReviewDismissedIssueEvent!);
            }
            else if (IsLockedIssueEvent)
            {
                lockedIssueEvent?.Invoke(LockedIssueEvent!);
            }
            else if (IsAddedToProjectIssueEvent)
            {
                addedToProjectIssueEvent?.Invoke(AddedToProjectIssueEvent!);
            }
            else if (IsMovedColumnInProjectIssueEvent)
            {
                movedColumnInProjectIssueEvent?.Invoke(MovedColumnInProjectIssueEvent!);
            }
            else if (IsRemovedFromProjectIssueEvent)
            {
                removedFromProjectIssueEvent?.Invoke(RemovedFromProjectIssueEvent!);
            }
            else if (IsConvertedNoteToIssueIssueEvent)
            {
                convertedNoteToIssueIssueEvent?.Invoke(ConvertedNoteToIssueIssueEvent!);
            }
            else if (IsTimelineCommentEvent)
            {
                timelineCommentEvent?.Invoke(TimelineCommentEvent!);
            }
            else if (IsTimelineCrossReferencedEvent)
            {
                timelineCrossReferencedEvent?.Invoke(TimelineCrossReferencedEvent!);
            }
            else if (IsTimelineCommittedEvent)
            {
                timelineCommittedEvent?.Invoke(TimelineCommittedEvent!);
            }
            else if (IsTimelineReviewedEvent)
            {
                timelineReviewedEvent?.Invoke(TimelineReviewedEvent!);
            }
            else if (IsTimelineLineCommentedEvent)
            {
                timelineLineCommentedEvent?.Invoke(TimelineLineCommentedEvent!);
            }
            else if (IsTimelineCommitCommentedEvent)
            {
                timelineCommitCommentedEvent?.Invoke(TimelineCommitCommentedEvent!);
            }
            else if (IsTimelineAssignedIssueEvent)
            {
                timelineAssignedIssueEvent?.Invoke(TimelineAssignedIssueEvent!);
            }
            else if (IsTimelineUnassignedIssueEvent)
            {
                timelineUnassignedIssueEvent?.Invoke(TimelineUnassignedIssueEvent!);
            }
            else if (IsStateChangeIssueEvent)
            {
                stateChangeIssueEvent?.Invoke(StateChangeIssueEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabeledIssueEvent,
                typeof(global::G.LabeledIssueEvent),
                UnlabeledIssueEvent,
                typeof(global::G.UnlabeledIssueEvent),
                MilestonedIssueEvent,
                typeof(global::G.MilestonedIssueEvent),
                DemilestonedIssueEvent,
                typeof(global::G.DemilestonedIssueEvent),
                RenamedIssueEvent,
                typeof(global::G.RenamedIssueEvent),
                ReviewRequestedIssueEvent,
                typeof(global::G.ReviewRequestedIssueEvent),
                ReviewRequestRemovedIssueEvent,
                typeof(global::G.ReviewRequestRemovedIssueEvent),
                ReviewDismissedIssueEvent,
                typeof(global::G.ReviewDismissedIssueEvent),
                LockedIssueEvent,
                typeof(global::G.LockedIssueEvent),
                AddedToProjectIssueEvent,
                typeof(global::G.AddedToProjectIssueEvent),
                MovedColumnInProjectIssueEvent,
                typeof(global::G.MovedColumnInProjectIssueEvent),
                RemovedFromProjectIssueEvent,
                typeof(global::G.RemovedFromProjectIssueEvent),
                ConvertedNoteToIssueIssueEvent,
                typeof(global::G.ConvertedNoteToIssueIssueEvent),
                TimelineCommentEvent,
                typeof(global::G.TimelineCommentEvent),
                TimelineCrossReferencedEvent,
                typeof(global::G.TimelineCrossReferencedEvent),
                TimelineCommittedEvent,
                typeof(global::G.TimelineCommittedEvent),
                TimelineReviewedEvent,
                typeof(global::G.TimelineReviewedEvent),
                TimelineLineCommentedEvent,
                typeof(global::G.TimelineLineCommentedEvent),
                TimelineCommitCommentedEvent,
                typeof(global::G.TimelineCommitCommentedEvent),
                TimelineAssignedIssueEvent,
                typeof(global::G.TimelineAssignedIssueEvent),
                TimelineUnassignedIssueEvent,
                typeof(global::G.TimelineUnassignedIssueEvent),
                StateChangeIssueEvent,
                typeof(global::G.StateChangeIssueEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TimelineIssueEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LabeledIssueEvent?>.Default.Equals(LabeledIssueEvent, other.LabeledIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UnlabeledIssueEvent?>.Default.Equals(UnlabeledIssueEvent, other.UnlabeledIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MilestonedIssueEvent?>.Default.Equals(MilestonedIssueEvent, other.MilestonedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DemilestonedIssueEvent?>.Default.Equals(DemilestonedIssueEvent, other.DemilestonedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RenamedIssueEvent?>.Default.Equals(RenamedIssueEvent, other.RenamedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestedIssueEvent?>.Default.Equals(ReviewRequestedIssueEvent, other.ReviewRequestedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewRequestRemovedIssueEvent?>.Default.Equals(ReviewRequestRemovedIssueEvent, other.ReviewRequestRemovedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReviewDismissedIssueEvent?>.Default.Equals(ReviewDismissedIssueEvent, other.ReviewDismissedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LockedIssueEvent?>.Default.Equals(LockedIssueEvent, other.LockedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AddedToProjectIssueEvent?>.Default.Equals(AddedToProjectIssueEvent, other.AddedToProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MovedColumnInProjectIssueEvent?>.Default.Equals(MovedColumnInProjectIssueEvent, other.MovedColumnInProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RemovedFromProjectIssueEvent?>.Default.Equals(RemovedFromProjectIssueEvent, other.RemovedFromProjectIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConvertedNoteToIssueIssueEvent?>.Default.Equals(ConvertedNoteToIssueIssueEvent, other.ConvertedNoteToIssueIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCommentEvent?>.Default.Equals(TimelineCommentEvent, other.TimelineCommentEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCrossReferencedEvent?>.Default.Equals(TimelineCrossReferencedEvent, other.TimelineCrossReferencedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCommittedEvent?>.Default.Equals(TimelineCommittedEvent, other.TimelineCommittedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineReviewedEvent?>.Default.Equals(TimelineReviewedEvent, other.TimelineReviewedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineLineCommentedEvent?>.Default.Equals(TimelineLineCommentedEvent, other.TimelineLineCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineCommitCommentedEvent?>.Default.Equals(TimelineCommitCommentedEvent, other.TimelineCommitCommentedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineAssignedIssueEvent?>.Default.Equals(TimelineAssignedIssueEvent, other.TimelineAssignedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TimelineUnassignedIssueEvent?>.Default.Equals(TimelineUnassignedIssueEvent, other.TimelineUnassignedIssueEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StateChangeIssueEvent?>.Default.Equals(StateChangeIssueEvent, other.StateChangeIssueEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TimelineIssueEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TimelineIssueEvents obj1, TimelineIssueEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TimelineIssueEvents o && Equals(o);
        }
    }
}
