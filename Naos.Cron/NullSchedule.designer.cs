﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.79.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Cron
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class NullSchedule : IModel<NullSchedule>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="NullSchedule"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(NullSchedule left, NullSchedule right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="NullSchedule"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(NullSchedule left, NullSchedule right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(NullSchedule other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = true;

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as NullSchedule);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Value;

        /// <inheritdoc />
        public new NullSchedule DeepClone() => (NullSchedule)this.DeepCloneInternal();

        /// <inheritdoc />
        protected override ScheduleBase DeepCloneInternal()
        {
            var result = new NullSchedule();

            return result;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var result = Invariant($"Naos.Cron.NullSchedule: <no properties>.");

            return result;
        }
    }
}