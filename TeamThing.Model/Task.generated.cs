#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using TeamThing.Model;


namespace TeamThing.Model	
{
	public partial class Task : ThingBase
	{
		private TaskStatus _status;
		public virtual TaskStatus Status 
		{ 
		    get
		    {
		        return this._status;
		    }
		    set
		    {
		        this._status = value;
		    }
		}
		
		private TaskType _taskType;
		public virtual TaskType TaskType 
		{ 
		    get
		    {
		        return this._taskType;
		    }
		    set
		    {
		        this._taskType = value;
		    }
		}
		
	}
}
