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
        /// 
        /// </summary>
        public bool TryPickLabeledIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.LabeledIssueEvent? value)
        {
            value = LabeledIssueEvent;
            return IsLabeledIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.LabeledIssueEvent PickLabeledIssueEvent() => LabeledIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LabeledIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickUnlabeledIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.UnlabeledIssueEvent? value)
        {
            value = UnlabeledIssueEvent;
            return IsUnlabeledIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.UnlabeledIssueEvent PickUnlabeledIssueEvent() => UnlabeledIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnlabeledIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMilestonedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MilestonedIssueEvent? value)
        {
            value = MilestonedIssueEvent;
            return IsMilestonedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MilestonedIssueEvent PickMilestonedIssueEvent() => MilestonedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MilestonedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDemilestonedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.DemilestonedIssueEvent? value)
        {
            value = DemilestonedIssueEvent;
            return IsDemilestonedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.DemilestonedIssueEvent PickDemilestonedIssueEvent() => DemilestonedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DemilestonedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickRenamedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RenamedIssueEvent? value)
        {
            value = RenamedIssueEvent;
            return IsRenamedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RenamedIssueEvent PickRenamedIssueEvent() => RenamedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RenamedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickReviewRequestedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ReviewRequestedIssueEvent? value)
        {
            value = ReviewRequestedIssueEvent;
            return IsReviewRequestedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ReviewRequestedIssueEvent PickReviewRequestedIssueEvent() => ReviewRequestedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewRequestedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickReviewRequestRemovedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ReviewRequestRemovedIssueEvent? value)
        {
            value = ReviewRequestRemovedIssueEvent;
            return IsReviewRequestRemovedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ReviewRequestRemovedIssueEvent PickReviewRequestRemovedIssueEvent() => ReviewRequestRemovedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewRequestRemovedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickReviewDismissedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ReviewDismissedIssueEvent? value)
        {
            value = ReviewDismissedIssueEvent;
            return IsReviewDismissedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ReviewDismissedIssueEvent PickReviewDismissedIssueEvent() => ReviewDismissedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewDismissedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLockedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.LockedIssueEvent? value)
        {
            value = LockedIssueEvent;
            return IsLockedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.LockedIssueEvent PickLockedIssueEvent() => LockedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LockedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickAddedToProjectIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.AddedToProjectIssueEvent? value)
        {
            value = AddedToProjectIssueEvent;
            return IsAddedToProjectIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.AddedToProjectIssueEvent PickAddedToProjectIssueEvent() => AddedToProjectIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AddedToProjectIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMovedColumnInProjectIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MovedColumnInProjectIssueEvent? value)
        {
            value = MovedColumnInProjectIssueEvent;
            return IsMovedColumnInProjectIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MovedColumnInProjectIssueEvent PickMovedColumnInProjectIssueEvent() => MovedColumnInProjectIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MovedColumnInProjectIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickRemovedFromProjectIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RemovedFromProjectIssueEvent? value)
        {
            value = RemovedFromProjectIssueEvent;
            return IsRemovedFromProjectIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RemovedFromProjectIssueEvent PickRemovedFromProjectIssueEvent() => RemovedFromProjectIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RemovedFromProjectIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickConvertedNoteToIssueIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConvertedNoteToIssueIssueEvent? value)
        {
            value = ConvertedNoteToIssueIssueEvent;
            return IsConvertedNoteToIssueIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConvertedNoteToIssueIssueEvent PickConvertedNoteToIssueIssueEvent() => ConvertedNoteToIssueIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConvertedNoteToIssueIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineCommentEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineCommentEvent? value)
        {
            value = TimelineCommentEvent;
            return IsTimelineCommentEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineCommentEvent PickTimelineCommentEvent() => TimelineCommentEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCommentEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineCrossReferencedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineCrossReferencedEvent? value)
        {
            value = TimelineCrossReferencedEvent;
            return IsTimelineCrossReferencedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineCrossReferencedEvent PickTimelineCrossReferencedEvent() => TimelineCrossReferencedEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCrossReferencedEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineCommittedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineCommittedEvent? value)
        {
            value = TimelineCommittedEvent;
            return IsTimelineCommittedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineCommittedEvent PickTimelineCommittedEvent() => TimelineCommittedEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCommittedEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineReviewedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineReviewedEvent? value)
        {
            value = TimelineReviewedEvent;
            return IsTimelineReviewedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineReviewedEvent PickTimelineReviewedEvent() => TimelineReviewedEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineReviewedEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineLineCommentedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineLineCommentedEvent? value)
        {
            value = TimelineLineCommentedEvent;
            return IsTimelineLineCommentedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineLineCommentedEvent PickTimelineLineCommentedEvent() => TimelineLineCommentedEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineLineCommentedEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineCommitCommentedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineCommitCommentedEvent? value)
        {
            value = TimelineCommitCommentedEvent;
            return IsTimelineCommitCommentedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineCommitCommentedEvent PickTimelineCommitCommentedEvent() => TimelineCommitCommentedEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineCommitCommentedEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineAssignedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineAssignedIssueEvent? value)
        {
            value = TimelineAssignedIssueEvent;
            return IsTimelineAssignedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineAssignedIssueEvent PickTimelineAssignedIssueEvent() => TimelineAssignedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineAssignedIssueEvent' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickTimelineUnassignedIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.TimelineUnassignedIssueEvent? value)
        {
            value = TimelineUnassignedIssueEvent;
            return IsTimelineUnassignedIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.TimelineUnassignedIssueEvent PickTimelineUnassignedIssueEvent() => TimelineUnassignedIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimelineUnassignedIssueEvent' but the value was {ToString()}.");

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
        public bool TryPickStateChangeIssueEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.StateChangeIssueEvent? value)
        {
            value = StateChangeIssueEvent;
            return IsStateChangeIssueEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.StateChangeIssueEvent PickStateChangeIssueEvent() => StateChangeIssueEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StateChangeIssueEvent' but the value was {ToString()}.");
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
        public static TimelineIssueEvents FromLabeledIssueEvent(global::G.LabeledIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromUnlabeledIssueEvent(global::G.UnlabeledIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromMilestonedIssueEvent(global::G.MilestonedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromDemilestonedIssueEvent(global::G.DemilestonedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromRenamedIssueEvent(global::G.RenamedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromReviewRequestedIssueEvent(global::G.ReviewRequestedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromReviewRequestRemovedIssueEvent(global::G.ReviewRequestRemovedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromReviewDismissedIssueEvent(global::G.ReviewDismissedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromLockedIssueEvent(global::G.LockedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromAddedToProjectIssueEvent(global::G.AddedToProjectIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromMovedColumnInProjectIssueEvent(global::G.MovedColumnInProjectIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromRemovedFromProjectIssueEvent(global::G.RemovedFromProjectIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromConvertedNoteToIssueIssueEvent(global::G.ConvertedNoteToIssueIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineCommentEvent(global::G.TimelineCommentEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineCrossReferencedEvent(global::G.TimelineCrossReferencedEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineCommittedEvent(global::G.TimelineCommittedEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineReviewedEvent(global::G.TimelineReviewedEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineLineCommentedEvent(global::G.TimelineLineCommentedEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineCommitCommentedEvent(global::G.TimelineCommitCommentedEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineAssignedIssueEvent(global::G.TimelineAssignedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromTimelineUnassignedIssueEvent(global::G.TimelineUnassignedIssueEvent? value) => new TimelineIssueEvents(value);

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
        public static TimelineIssueEvents FromStateChangeIssueEvent(global::G.StateChangeIssueEvent? value) => new TimelineIssueEvents(value);

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
            global::System.Func<global::G.LabeledIssueEvent, TResult>? labeledIssueEvent = null,
            global::System.Func<global::G.UnlabeledIssueEvent, TResult>? unlabeledIssueEvent = null,
            global::System.Func<global::G.MilestonedIssueEvent, TResult>? milestonedIssueEvent = null,
            global::System.Func<global::G.DemilestonedIssueEvent, TResult>? demilestonedIssueEvent = null,
            global::System.Func<global::G.RenamedIssueEvent, TResult>? renamedIssueEvent = null,
            global::System.Func<global::G.ReviewRequestedIssueEvent, TResult>? reviewRequestedIssueEvent = null,
            global::System.Func<global::G.ReviewRequestRemovedIssueEvent, TResult>? reviewRequestRemovedIssueEvent = null,
            global::System.Func<global::G.ReviewDismissedIssueEvent, TResult>? reviewDismissedIssueEvent = null,
            global::System.Func<global::G.LockedIssueEvent, TResult>? lockedIssueEvent = null,
            global::System.Func<global::G.AddedToProjectIssueEvent, TResult>? addedToProjectIssueEvent = null,
            global::System.Func<global::G.MovedColumnInProjectIssueEvent, TResult>? movedColumnInProjectIssueEvent = null,
            global::System.Func<global::G.RemovedFromProjectIssueEvent, TResult>? removedFromProjectIssueEvent = null,
            global::System.Func<global::G.ConvertedNoteToIssueIssueEvent, TResult>? convertedNoteToIssueIssueEvent = null,
            global::System.Func<global::G.TimelineCommentEvent, TResult>? timelineCommentEvent = null,
            global::System.Func<global::G.TimelineCrossReferencedEvent, TResult>? timelineCrossReferencedEvent = null,
            global::System.Func<global::G.TimelineCommittedEvent, TResult>? timelineCommittedEvent = null,
            global::System.Func<global::G.TimelineReviewedEvent, TResult>? timelineReviewedEvent = null,
            global::System.Func<global::G.TimelineLineCommentedEvent, TResult>? timelineLineCommentedEvent = null,
            global::System.Func<global::G.TimelineCommitCommentedEvent, TResult>? timelineCommitCommentedEvent = null,
            global::System.Func<global::G.TimelineAssignedIssueEvent, TResult>? timelineAssignedIssueEvent = null,
            global::System.Func<global::G.TimelineUnassignedIssueEvent, TResult>? timelineUnassignedIssueEvent = null,
            global::System.Func<global::G.StateChangeIssueEvent, TResult>? stateChangeIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LabeledIssueEvent is { } __value0 && labeledIssueEvent != null)
            {
                return labeledIssueEvent(__value0);
            }
            else if (UnlabeledIssueEvent is { } __value1 && unlabeledIssueEvent != null)
            {
                return unlabeledIssueEvent(__value1);
            }
            else if (MilestonedIssueEvent is { } __value2 && milestonedIssueEvent != null)
            {
                return milestonedIssueEvent(__value2);
            }
            else if (DemilestonedIssueEvent is { } __value3 && demilestonedIssueEvent != null)
            {
                return demilestonedIssueEvent(__value3);
            }
            else if (RenamedIssueEvent is { } __value4 && renamedIssueEvent != null)
            {
                return renamedIssueEvent(__value4);
            }
            else if (ReviewRequestedIssueEvent is { } __value5 && reviewRequestedIssueEvent != null)
            {
                return reviewRequestedIssueEvent(__value5);
            }
            else if (ReviewRequestRemovedIssueEvent is { } __value6 && reviewRequestRemovedIssueEvent != null)
            {
                return reviewRequestRemovedIssueEvent(__value6);
            }
            else if (ReviewDismissedIssueEvent is { } __value7 && reviewDismissedIssueEvent != null)
            {
                return reviewDismissedIssueEvent(__value7);
            }
            else if (LockedIssueEvent is { } __value8 && lockedIssueEvent != null)
            {
                return lockedIssueEvent(__value8);
            }
            else if (AddedToProjectIssueEvent is { } __value9 && addedToProjectIssueEvent != null)
            {
                return addedToProjectIssueEvent(__value9);
            }
            else if (MovedColumnInProjectIssueEvent is { } __value10 && movedColumnInProjectIssueEvent != null)
            {
                return movedColumnInProjectIssueEvent(__value10);
            }
            else if (RemovedFromProjectIssueEvent is { } __value11 && removedFromProjectIssueEvent != null)
            {
                return removedFromProjectIssueEvent(__value11);
            }
            else if (ConvertedNoteToIssueIssueEvent is { } __value12 && convertedNoteToIssueIssueEvent != null)
            {
                return convertedNoteToIssueIssueEvent(__value12);
            }
            else if (TimelineCommentEvent is { } __value13 && timelineCommentEvent != null)
            {
                return timelineCommentEvent(__value13);
            }
            else if (TimelineCrossReferencedEvent is { } __value14 && timelineCrossReferencedEvent != null)
            {
                return timelineCrossReferencedEvent(__value14);
            }
            else if (TimelineCommittedEvent is { } __value15 && timelineCommittedEvent != null)
            {
                return timelineCommittedEvent(__value15);
            }
            else if (TimelineReviewedEvent is { } __value16 && timelineReviewedEvent != null)
            {
                return timelineReviewedEvent(__value16);
            }
            else if (TimelineLineCommentedEvent is { } __value17 && timelineLineCommentedEvent != null)
            {
                return timelineLineCommentedEvent(__value17);
            }
            else if (TimelineCommitCommentedEvent is { } __value18 && timelineCommitCommentedEvent != null)
            {
                return timelineCommitCommentedEvent(__value18);
            }
            else if (TimelineAssignedIssueEvent is { } __value19 && timelineAssignedIssueEvent != null)
            {
                return timelineAssignedIssueEvent(__value19);
            }
            else if (TimelineUnassignedIssueEvent is { } __value20 && timelineUnassignedIssueEvent != null)
            {
                return timelineUnassignedIssueEvent(__value20);
            }
            else if (StateChangeIssueEvent is { } __value21 && stateChangeIssueEvent != null)
            {
                return stateChangeIssueEvent(__value21);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LabeledIssueEvent>? labeledIssueEvent = null,

            global::System.Action<global::G.UnlabeledIssueEvent>? unlabeledIssueEvent = null,

            global::System.Action<global::G.MilestonedIssueEvent>? milestonedIssueEvent = null,

            global::System.Action<global::G.DemilestonedIssueEvent>? demilestonedIssueEvent = null,

            global::System.Action<global::G.RenamedIssueEvent>? renamedIssueEvent = null,

            global::System.Action<global::G.ReviewRequestedIssueEvent>? reviewRequestedIssueEvent = null,

            global::System.Action<global::G.ReviewRequestRemovedIssueEvent>? reviewRequestRemovedIssueEvent = null,

            global::System.Action<global::G.ReviewDismissedIssueEvent>? reviewDismissedIssueEvent = null,

            global::System.Action<global::G.LockedIssueEvent>? lockedIssueEvent = null,

            global::System.Action<global::G.AddedToProjectIssueEvent>? addedToProjectIssueEvent = null,

            global::System.Action<global::G.MovedColumnInProjectIssueEvent>? movedColumnInProjectIssueEvent = null,

            global::System.Action<global::G.RemovedFromProjectIssueEvent>? removedFromProjectIssueEvent = null,

            global::System.Action<global::G.ConvertedNoteToIssueIssueEvent>? convertedNoteToIssueIssueEvent = null,

            global::System.Action<global::G.TimelineCommentEvent>? timelineCommentEvent = null,

            global::System.Action<global::G.TimelineCrossReferencedEvent>? timelineCrossReferencedEvent = null,

            global::System.Action<global::G.TimelineCommittedEvent>? timelineCommittedEvent = null,

            global::System.Action<global::G.TimelineReviewedEvent>? timelineReviewedEvent = null,

            global::System.Action<global::G.TimelineLineCommentedEvent>? timelineLineCommentedEvent = null,

            global::System.Action<global::G.TimelineCommitCommentedEvent>? timelineCommitCommentedEvent = null,

            global::System.Action<global::G.TimelineAssignedIssueEvent>? timelineAssignedIssueEvent = null,

            global::System.Action<global::G.TimelineUnassignedIssueEvent>? timelineUnassignedIssueEvent = null,

            global::System.Action<global::G.StateChangeIssueEvent>? stateChangeIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LabeledIssueEvent is { } __value0)
            {
                labeledIssueEvent?.Invoke(__value0);
            }
            else if (UnlabeledIssueEvent is { } __value1)
            {
                unlabeledIssueEvent?.Invoke(__value1);
            }
            else if (MilestonedIssueEvent is { } __value2)
            {
                milestonedIssueEvent?.Invoke(__value2);
            }
            else if (DemilestonedIssueEvent is { } __value3)
            {
                demilestonedIssueEvent?.Invoke(__value3);
            }
            else if (RenamedIssueEvent is { } __value4)
            {
                renamedIssueEvent?.Invoke(__value4);
            }
            else if (ReviewRequestedIssueEvent is { } __value5)
            {
                reviewRequestedIssueEvent?.Invoke(__value5);
            }
            else if (ReviewRequestRemovedIssueEvent is { } __value6)
            {
                reviewRequestRemovedIssueEvent?.Invoke(__value6);
            }
            else if (ReviewDismissedIssueEvent is { } __value7)
            {
                reviewDismissedIssueEvent?.Invoke(__value7);
            }
            else if (LockedIssueEvent is { } __value8)
            {
                lockedIssueEvent?.Invoke(__value8);
            }
            else if (AddedToProjectIssueEvent is { } __value9)
            {
                addedToProjectIssueEvent?.Invoke(__value9);
            }
            else if (MovedColumnInProjectIssueEvent is { } __value10)
            {
                movedColumnInProjectIssueEvent?.Invoke(__value10);
            }
            else if (RemovedFromProjectIssueEvent is { } __value11)
            {
                removedFromProjectIssueEvent?.Invoke(__value11);
            }
            else if (ConvertedNoteToIssueIssueEvent is { } __value12)
            {
                convertedNoteToIssueIssueEvent?.Invoke(__value12);
            }
            else if (TimelineCommentEvent is { } __value13)
            {
                timelineCommentEvent?.Invoke(__value13);
            }
            else if (TimelineCrossReferencedEvent is { } __value14)
            {
                timelineCrossReferencedEvent?.Invoke(__value14);
            }
            else if (TimelineCommittedEvent is { } __value15)
            {
                timelineCommittedEvent?.Invoke(__value15);
            }
            else if (TimelineReviewedEvent is { } __value16)
            {
                timelineReviewedEvent?.Invoke(__value16);
            }
            else if (TimelineLineCommentedEvent is { } __value17)
            {
                timelineLineCommentedEvent?.Invoke(__value17);
            }
            else if (TimelineCommitCommentedEvent is { } __value18)
            {
                timelineCommitCommentedEvent?.Invoke(__value18);
            }
            else if (TimelineAssignedIssueEvent is { } __value19)
            {
                timelineAssignedIssueEvent?.Invoke(__value19);
            }
            else if (TimelineUnassignedIssueEvent is { } __value20)
            {
                timelineUnassignedIssueEvent?.Invoke(__value20);
            }
            else if (StateChangeIssueEvent is { } __value21)
            {
                stateChangeIssueEvent?.Invoke(__value21);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.LabeledIssueEvent>? labeledIssueEvent = null,
            global::System.Action<global::G.UnlabeledIssueEvent>? unlabeledIssueEvent = null,
            global::System.Action<global::G.MilestonedIssueEvent>? milestonedIssueEvent = null,
            global::System.Action<global::G.DemilestonedIssueEvent>? demilestonedIssueEvent = null,
            global::System.Action<global::G.RenamedIssueEvent>? renamedIssueEvent = null,
            global::System.Action<global::G.ReviewRequestedIssueEvent>? reviewRequestedIssueEvent = null,
            global::System.Action<global::G.ReviewRequestRemovedIssueEvent>? reviewRequestRemovedIssueEvent = null,
            global::System.Action<global::G.ReviewDismissedIssueEvent>? reviewDismissedIssueEvent = null,
            global::System.Action<global::G.LockedIssueEvent>? lockedIssueEvent = null,
            global::System.Action<global::G.AddedToProjectIssueEvent>? addedToProjectIssueEvent = null,
            global::System.Action<global::G.MovedColumnInProjectIssueEvent>? movedColumnInProjectIssueEvent = null,
            global::System.Action<global::G.RemovedFromProjectIssueEvent>? removedFromProjectIssueEvent = null,
            global::System.Action<global::G.ConvertedNoteToIssueIssueEvent>? convertedNoteToIssueIssueEvent = null,
            global::System.Action<global::G.TimelineCommentEvent>? timelineCommentEvent = null,
            global::System.Action<global::G.TimelineCrossReferencedEvent>? timelineCrossReferencedEvent = null,
            global::System.Action<global::G.TimelineCommittedEvent>? timelineCommittedEvent = null,
            global::System.Action<global::G.TimelineReviewedEvent>? timelineReviewedEvent = null,
            global::System.Action<global::G.TimelineLineCommentedEvent>? timelineLineCommentedEvent = null,
            global::System.Action<global::G.TimelineCommitCommentedEvent>? timelineCommitCommentedEvent = null,
            global::System.Action<global::G.TimelineAssignedIssueEvent>? timelineAssignedIssueEvent = null,
            global::System.Action<global::G.TimelineUnassignedIssueEvent>? timelineUnassignedIssueEvent = null,
            global::System.Action<global::G.StateChangeIssueEvent>? stateChangeIssueEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (LabeledIssueEvent is { } __value0)
            {
                labeledIssueEvent?.Invoke(__value0);
            }
            else if (UnlabeledIssueEvent is { } __value1)
            {
                unlabeledIssueEvent?.Invoke(__value1);
            }
            else if (MilestonedIssueEvent is { } __value2)
            {
                milestonedIssueEvent?.Invoke(__value2);
            }
            else if (DemilestonedIssueEvent is { } __value3)
            {
                demilestonedIssueEvent?.Invoke(__value3);
            }
            else if (RenamedIssueEvent is { } __value4)
            {
                renamedIssueEvent?.Invoke(__value4);
            }
            else if (ReviewRequestedIssueEvent is { } __value5)
            {
                reviewRequestedIssueEvent?.Invoke(__value5);
            }
            else if (ReviewRequestRemovedIssueEvent is { } __value6)
            {
                reviewRequestRemovedIssueEvent?.Invoke(__value6);
            }
            else if (ReviewDismissedIssueEvent is { } __value7)
            {
                reviewDismissedIssueEvent?.Invoke(__value7);
            }
            else if (LockedIssueEvent is { } __value8)
            {
                lockedIssueEvent?.Invoke(__value8);
            }
            else if (AddedToProjectIssueEvent is { } __value9)
            {
                addedToProjectIssueEvent?.Invoke(__value9);
            }
            else if (MovedColumnInProjectIssueEvent is { } __value10)
            {
                movedColumnInProjectIssueEvent?.Invoke(__value10);
            }
            else if (RemovedFromProjectIssueEvent is { } __value11)
            {
                removedFromProjectIssueEvent?.Invoke(__value11);
            }
            else if (ConvertedNoteToIssueIssueEvent is { } __value12)
            {
                convertedNoteToIssueIssueEvent?.Invoke(__value12);
            }
            else if (TimelineCommentEvent is { } __value13)
            {
                timelineCommentEvent?.Invoke(__value13);
            }
            else if (TimelineCrossReferencedEvent is { } __value14)
            {
                timelineCrossReferencedEvent?.Invoke(__value14);
            }
            else if (TimelineCommittedEvent is { } __value15)
            {
                timelineCommittedEvent?.Invoke(__value15);
            }
            else if (TimelineReviewedEvent is { } __value16)
            {
                timelineReviewedEvent?.Invoke(__value16);
            }
            else if (TimelineLineCommentedEvent is { } __value17)
            {
                timelineLineCommentedEvent?.Invoke(__value17);
            }
            else if (TimelineCommitCommentedEvent is { } __value18)
            {
                timelineCommitCommentedEvent?.Invoke(__value18);
            }
            else if (TimelineAssignedIssueEvent is { } __value19)
            {
                timelineAssignedIssueEvent?.Invoke(__value19);
            }
            else if (TimelineUnassignedIssueEvent is { } __value20)
            {
                timelineUnassignedIssueEvent?.Invoke(__value20);
            }
            else if (StateChangeIssueEvent is { } __value21)
            {
                stateChangeIssueEvent?.Invoke(__value21);
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
