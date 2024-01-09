using Grpc.Core;

namespace Exec_Broker.Services
{
    public class Exec_ControlService : Exec_Control.Exec_ControlBase
    {
        public override Task<WkrUpdateResp> WkrUpdate(WkrUpdateData request, ServerCallContext context)
        {
            WkrUpdateResp resp = new ();



            return Task.FromResult(resp);
        }

    }
}
