using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.Access
{
#if ENTERPRISE
	using System.Runtime.InteropServices;
    /// <summary>
    /// Access���ݿ�Domain��Ϣ
    /// </summary>
    [ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IDomain))]
#endif 
	public class AccessDomain : Domain
	{
		public AccessDomain()
		{

		}
	}
}
