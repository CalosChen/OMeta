using System;
using System.Data;
using System.Data.OleDb;

namespace OMeta.Access
{
#if ENTERPRISE
	using System.Runtime.InteropServices;
    /// <summary>
    /// Access���ݿ� Domain������Ϣ
    /// </summary>
    [ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IDomains))]
#endif 
	public class AccessDomains : Domains
	{
		public AccessDomains()
		{

		}
	}
}
