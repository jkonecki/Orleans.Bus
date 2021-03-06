﻿using System;
using System.Linq;

using Orleans.Concurrency;

namespace Orleans.Bus
{
    public interface Command
    {}

    [Serializable, Immutable]
    public class CommandEnvelope
    {
        public readonly Guid Id;
        public readonly Command Body;

        public CommandEnvelope(Guid id, Command body)
        {
            Id = id;
            Body = body;
        }
    }

    public interface Query
    {}

    public interface Query<TResult> : Query
    {}

    [Serializable, Immutable]
    public class QueryEnvelope<TResult>
    {
        public readonly Guid Id;
        public readonly Query<TResult> Body;

        public QueryEnvelope(Guid id, Query<TResult> body)
        {
            Id = id;
            Body = body;
        }
    }

    public interface Event
    {}
}
