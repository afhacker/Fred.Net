﻿using System.ComponentModel;

namespace Fred.Net.Types.Enums
{
    public enum TagOrderBy
    {
        [Description("popularity")]
        Popularity,

        [Description("series_count")]
        SeriesCount,

        [Description("created")]
        Created,

        [Description("name")]
        Name,

        [Description("group_id")]
        GroupId,
    }
}