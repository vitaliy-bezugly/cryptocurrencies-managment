using Cryptocurrencies.Application.Common.Mappings;
using Cryptocurrencies.Contracts.Dtos;

namespace Cryptocurrencies.Application.Common.Models;

public record CoinHistoryModel : IMapFrom<CoinHistoryDto>
{
    public decimal PriceUsd { get; init; }

    public long Time { get; init; } = 0;
}