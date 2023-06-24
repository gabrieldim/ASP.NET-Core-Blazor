using BlazorServerApp.Models;

namespace BlazorServerApp.Service
{
    public interface IRevenueService
    {
        List<Revenue> getRevenues();
    }
}
