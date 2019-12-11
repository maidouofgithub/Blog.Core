﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Model.Models
{
    /// <summary>
    /// Tibug 博文
    /// </summary>
    public class TopicDetail : RootEntity
    {
        public TopicDetail()
        {
            this.tdUpdatetime = DateTime.Now;
        }

        public int TopicId { get; set; }

        [SugarColumn(Length = 200, IsNullable = true,ColumnDataType ="nvarchar")]
        public string tdLogo { get; set; } 

        [SugarColumn(Length = 200, IsNullable = true,ColumnDataType ="nvarchar")]
        public string tdName { get; set; }

        [SugarColumn(Length = int.MaxValue , IsNullable = true,ColumnDataType ="nvarchar")]
        public string tdContent { get; set; }

        [SugarColumn(Length = 400, IsNullable = true,ColumnDataType ="nvarchar")]
        public string tdDetail { get; set; }

        [SugarColumn(Length = 200, IsNullable = true,ColumnDataType ="nvarchar")]
        public string tdSectendDetail { get; set; }

        public bool tdIsDelete { get; set; } = false;
        public int tdRead { get; set; }
        public int tdCommend { get; set; }
        public int tdGood { get; set; }
        public DateTime tdCreatetime { get; set; }
        public DateTime tdUpdatetime { get; set; }
        public int tdTop { get; set; }

        [SugarColumn(Length = 200, IsNullable = true,ColumnDataType ="nvarchar")]
        public string tdAuthor { get; set; }


        [SugarColumn(IsIgnore = true)]
        public virtual Topic Topic { get; set; }

    }
}
