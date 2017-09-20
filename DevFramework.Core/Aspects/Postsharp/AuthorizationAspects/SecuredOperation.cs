using System;
using System.Security;
using PostSharp.Aspects;

namespace DevFramework.Core.Aspects.Postsharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation:OnMethodBoundaryAspect
    {
        
        public string Roles { get; set; }
        /// <summary>
        /// Eğer Kullanıcı benim rollerime sahipse, bu işlemi yapmasına izin ver.
        /// </summary>
        /// <param name="args"></param>
        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (!System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))
                {
                    isAuthorized = true;
                }
            }

            if (isAuthorized == false) 
            {
                throw new SecurityException("You are not authorized!");
            }
        }
    }
}