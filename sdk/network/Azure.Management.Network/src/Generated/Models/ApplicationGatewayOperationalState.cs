// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Operational state of the application gateway resource. </summary>
    public readonly partial struct ApplicationGatewayOperationalState : IEquatable<ApplicationGatewayOperationalState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewayOperationalState"/> values are the same. </summary>
        public ApplicationGatewayOperationalState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StoppedValue = "Stopped";
        private const string StartingValue = "Starting";
        private const string RunningValue = "Running";
        private const string StoppingValue = "Stopping";

        /// <summary> Stopped. </summary>
        public static ApplicationGatewayOperationalState Stopped { get; } = new ApplicationGatewayOperationalState(StoppedValue);
        /// <summary> Starting. </summary>
        public static ApplicationGatewayOperationalState Starting { get; } = new ApplicationGatewayOperationalState(StartingValue);
        /// <summary> Running. </summary>
        public static ApplicationGatewayOperationalState Running { get; } = new ApplicationGatewayOperationalState(RunningValue);
        /// <summary> Stopping. </summary>
        public static ApplicationGatewayOperationalState Stopping { get; } = new ApplicationGatewayOperationalState(StoppingValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayOperationalState"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayOperationalState left, ApplicationGatewayOperationalState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayOperationalState"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayOperationalState left, ApplicationGatewayOperationalState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayOperationalState"/>. </summary>
        public static implicit operator ApplicationGatewayOperationalState(string value) => new ApplicationGatewayOperationalState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayOperationalState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayOperationalState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
