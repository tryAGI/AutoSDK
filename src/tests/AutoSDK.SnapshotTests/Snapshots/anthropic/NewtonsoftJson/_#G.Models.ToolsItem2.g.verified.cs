//HintName: G.Models.ToolsItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem2 : global::System.IEquatable<ToolsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaCreateMessageParamsToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaTool? Custom { get; init; }
#else
        public global::G.BetaTool? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaTool value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTool?(ToolsItem2 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaTool? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaComputerUseTool20241022? Computer20241022 { get; init; }
#else
        public global::G.BetaComputerUseTool20241022? Computer20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer20241022))]
#endif
        public bool IsComputer20241022 => Computer20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaComputerUseTool20241022 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaComputerUseTool20241022?(ToolsItem2 @this) => @this.Computer20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaComputerUseTool20241022? value)
        {
            Computer20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaBashTool20241022? Bash20241022 { get; init; }
#else
        public global::G.BetaBashTool20241022? Bash20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash20241022))]
#endif
        public bool IsBash20241022 => Bash20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaBashTool20241022 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaBashTool20241022?(ToolsItem2 @this) => @this.Bash20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaBashTool20241022? value)
        {
            Bash20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaTextEditor20241022? TextEditor20241022 { get; init; }
#else
        public global::G.BetaTextEditor20241022? TextEditor20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20241022))]
#endif
        public bool IsTextEditor20241022 => TextEditor20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaTextEditor20241022 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTextEditor20241022?(ToolsItem2 @this) => @this.TextEditor20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaTextEditor20241022? value)
        {
            TextEditor20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaComputerUseTool20250124? Computer20250124 { get; init; }
#else
        public global::G.BetaComputerUseTool20250124? Computer20250124 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer20250124))]
#endif
        public bool IsComputer20250124 => Computer20250124 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaComputerUseTool20250124 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaComputerUseTool20250124?(ToolsItem2 @this) => @this.Computer20250124;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaComputerUseTool20250124? value)
        {
            Computer20250124 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaBashTool20250124? Bash20250124 { get; init; }
#else
        public global::G.BetaBashTool20250124? Bash20250124 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash20250124))]
#endif
        public bool IsBash20250124 => Bash20250124 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaBashTool20250124 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaBashTool20250124?(ToolsItem2 @this) => @this.Bash20250124;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaBashTool20250124? value)
        {
            Bash20250124 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaTextEditor20250124? TextEditor20250124 { get; init; }
#else
        public global::G.BetaTextEditor20250124? TextEditor20250124 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20250124))]
#endif
        public bool IsTextEditor20250124 => TextEditor20250124 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::G.BetaTextEditor20250124 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTextEditor20250124?(ToolsItem2 @this) => @this.TextEditor20250124;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::G.BetaTextEditor20250124? value)
        {
            TextEditor20250124 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(
            global::G.BetaCreateMessageParamsToolDiscriminatorType? type,
            global::G.BetaTool? custom,
            global::G.BetaComputerUseTool20241022? computer20241022,
            global::G.BetaBashTool20241022? bash20241022,
            global::G.BetaTextEditor20241022? textEditor20241022,
            global::G.BetaComputerUseTool20250124? computer20250124,
            global::G.BetaBashTool20250124? bash20250124,
            global::G.BetaTextEditor20250124? textEditor20250124
            )
        {
            Type = type;

            Custom = custom;
            Computer20241022 = computer20241022;
            Bash20241022 = bash20241022;
            TextEditor20241022 = textEditor20241022;
            Computer20250124 = computer20250124;
            Bash20250124 = bash20250124;
            TextEditor20250124 = textEditor20250124;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextEditor20250124 as object ??
            Bash20250124 as object ??
            Computer20250124 as object ??
            TextEditor20241022 as object ??
            Bash20241022 as object ??
            Computer20241022 as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Custom?.ToString() ??
            Computer20241022?.ToString() ??
            Bash20241022?.ToString() ??
            TextEditor20241022?.ToString() ??
            Computer20250124?.ToString() ??
            Bash20250124?.ToString() ??
            TextEditor20250124?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 && !IsComputer20250124 && !IsBash20250124 && !IsTextEditor20250124 || !IsCustom && IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 && !IsComputer20250124 && !IsBash20250124 && !IsTextEditor20250124 || !IsCustom && !IsComputer20241022 && IsBash20241022 && !IsTextEditor20241022 && !IsComputer20250124 && !IsBash20250124 && !IsTextEditor20250124 || !IsCustom && !IsComputer20241022 && !IsBash20241022 && IsTextEditor20241022 && !IsComputer20250124 && !IsBash20250124 && !IsTextEditor20250124 || !IsCustom && !IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 && IsComputer20250124 && !IsBash20250124 && !IsTextEditor20250124 || !IsCustom && !IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 && !IsComputer20250124 && IsBash20250124 && !IsTextEditor20250124 || !IsCustom && !IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 && !IsComputer20250124 && !IsBash20250124 && IsTextEditor20250124;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaTool?, TResult>? custom = null,
            global::System.Func<global::G.BetaComputerUseTool20241022?, TResult>? computer20241022 = null,
            global::System.Func<global::G.BetaBashTool20241022?, TResult>? bash20241022 = null,
            global::System.Func<global::G.BetaTextEditor20241022?, TResult>? textEditor20241022 = null,
            global::System.Func<global::G.BetaComputerUseTool20250124?, TResult>? computer20250124 = null,
            global::System.Func<global::G.BetaBashTool20250124?, TResult>? bash20250124 = null,
            global::System.Func<global::G.BetaTextEditor20250124?, TResult>? textEditor20250124 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsComputer20241022 && computer20241022 != null)
            {
                return computer20241022(Computer20241022!);
            }
            else if (IsBash20241022 && bash20241022 != null)
            {
                return bash20241022(Bash20241022!);
            }
            else if (IsTextEditor20241022 && textEditor20241022 != null)
            {
                return textEditor20241022(TextEditor20241022!);
            }
            else if (IsComputer20250124 && computer20250124 != null)
            {
                return computer20250124(Computer20250124!);
            }
            else if (IsBash20250124 && bash20250124 != null)
            {
                return bash20250124(Bash20250124!);
            }
            else if (IsTextEditor20250124 && textEditor20250124 != null)
            {
                return textEditor20250124(TextEditor20250124!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaTool?>? custom = null,
            global::System.Action<global::G.BetaComputerUseTool20241022?>? computer20241022 = null,
            global::System.Action<global::G.BetaBashTool20241022?>? bash20241022 = null,
            global::System.Action<global::G.BetaTextEditor20241022?>? textEditor20241022 = null,
            global::System.Action<global::G.BetaComputerUseTool20250124?>? computer20250124 = null,
            global::System.Action<global::G.BetaBashTool20250124?>? bash20250124 = null,
            global::System.Action<global::G.BetaTextEditor20250124?>? textEditor20250124 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsComputer20241022)
            {
                computer20241022?.Invoke(Computer20241022!);
            }
            else if (IsBash20241022)
            {
                bash20241022?.Invoke(Bash20241022!);
            }
            else if (IsTextEditor20241022)
            {
                textEditor20241022?.Invoke(TextEditor20241022!);
            }
            else if (IsComputer20250124)
            {
                computer20250124?.Invoke(Computer20250124!);
            }
            else if (IsBash20250124)
            {
                bash20250124?.Invoke(Bash20250124!);
            }
            else if (IsTextEditor20250124)
            {
                textEditor20250124?.Invoke(TextEditor20250124!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::G.BetaTool),
                Computer20241022,
                typeof(global::G.BetaComputerUseTool20241022),
                Bash20241022,
                typeof(global::G.BetaBashTool20241022),
                TextEditor20241022,
                typeof(global::G.BetaTextEditor20241022),
                Computer20250124,
                typeof(global::G.BetaComputerUseTool20250124),
                Bash20250124,
                typeof(global::G.BetaBashTool20250124),
                TextEditor20250124,
                typeof(global::G.BetaTextEditor20250124),
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
        public bool Equals(ToolsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaComputerUseTool20241022?>.Default.Equals(Computer20241022, other.Computer20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaBashTool20241022?>.Default.Equals(Bash20241022, other.Bash20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaTextEditor20241022?>.Default.Equals(TextEditor20241022, other.TextEditor20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaComputerUseTool20250124?>.Default.Equals(Computer20250124, other.Computer20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaBashTool20250124?>.Default.Equals(Bash20250124, other.Bash20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaTextEditor20250124?>.Default.Equals(TextEditor20250124, other.TextEditor20250124) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem2 obj1, ToolsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem2 obj1, ToolsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem2 o && Equals(o);
        }
    }
}
