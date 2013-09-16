using System;
using System.Web.UI;

//Javascript Includes
[assembly: WebResource("ASPTokenInputLib.scripts.jqueryRegister.min.js", "text/javascript")]
[assembly: WebResource("ASPTokenInputLib.scripts.jquery.tokeninput.min.js", "text/javascript")]

//CSS Includes
[assembly: WebResource("ASPTokenInputLib.styles.token-input.min.css", "text/css")]

namespace ASPTokenInputLib
{
    public sealed class ScriptRegister
    {
        public void RegisterScripts(Page page)
        {
            RegisterjQuery(page);
            RegisterjQueryTokenInput(page);

        }

        private void RegisterjQuery(Page page)
        {
            ScriptManager scriptManager = ScriptManager.GetCurrent(page);
            if (scriptManager == null)
            {
                throw new Exception("ScriptRegister requires a script manager.");
            }
            const string jqueryScriptKey = "verge_jQuery";
            ScriptManager.RegisterClientScriptInclude(page, typeof(Page), jqueryScriptKey,
                                                      page.ClientScript.GetWebResourceUrl(typeof(ScriptRegister),
                                                                                          "ASPTokenInputLib.scripts.jqueryRegister.min.js"));
        }


        private void RegisterjQueryTokenInput(Page page)
        {
            ScriptManager scriptManager = ScriptManager.GetCurrent(page);
            if (scriptManager == null)
            {
                throw new Exception("ScriptRegister requires a script manager.");
            }
            const string tokenInputScriptKey = "verge_JQueryTokenInput";
            ScriptManager.RegisterClientScriptInclude(page, typeof(Page), tokenInputScriptKey,
                                           page.ClientScript.GetWebResourceUrl(typeof(ScriptRegister),
                                                                "ASPTokenInputLib.scripts.jquery.tokeninput.min.js"));
        }

    }
}
