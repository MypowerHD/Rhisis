﻿using Ether.Network.Packets;
using System;

namespace Rhisis.Network.Packets.World
{
    /// <summary>
    /// Defines the <see cref="RangeAttackPacket"/> structure.
    /// </summary>
    public struct RangeAttackPacket : IEquatable<RangeAttackPacket>
    {
        /// <summary>
        /// Gets the attack message.
        /// </summary>
        public ObjectMessageType AttackMessage { get; }

        /// <summary>
        /// Gets the object id.
        /// </summary>
        public uint ObjectId { get; }

        /// <summary>
        /// Gets the item id.
        /// </summary>
        public uint ItemId { get; set; }

        /// <summary>
        /// Gets the id of the hit SFX.
        /// </summary>
        public int IdSfxHit { get; set; }

        public RangeAttackPacket(INetPacketStream packet)
        {
            this.AttackMessage = (ObjectMessageType)packet.Read<uint>();
            this.ObjectId = packet.Read<uint>();
            this.ItemId = packet.Read<uint>();
            this.IdSfxHit = packet.Read<int>();
        }

        public bool Equals(RangeAttackPacket other)
        {
            return this.AttackMessage == other.AttackMessage &&
                   this.ObjectId == other.ObjectId &&
                   this.ItemId == other.ItemId &&
                   this.IdSfxHit == other.IdSfxHit;
        }
    }
}
