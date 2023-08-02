using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Nethereum.Uniswap.Contracts.UniswapV3Factory.ContractDefinition;

namespace Nethereum.Uniswap.Contracts.UniswapV3Factory
{
    public partial class UniswapV3FactoryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, UniswapV3FactoryDeployment uniswapV3FactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<UniswapV3FactoryDeployment>().SendRequestAndWaitForReceiptAsync(uniswapV3FactoryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, UniswapV3FactoryDeployment uniswapV3FactoryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<UniswapV3FactoryDeployment>().SendRequestAsync(uniswapV3FactoryDeployment);
        }

        public static async Task<UniswapV3FactoryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, UniswapV3FactoryDeployment uniswapV3FactoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, uniswapV3FactoryDeployment, cancellationTokenSource);
            return new UniswapV3FactoryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public UniswapV3FactoryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> CreatePoolRequestAsync(CreatePoolFunction createPoolFunction)
        {
             return ContractHandler.SendRequestAsync(createPoolFunction);
        }

        public Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(CreatePoolFunction createPoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createPoolFunction, cancellationToken);
        }

        public Task<string> CreatePoolRequestAsync(string tokenA, string tokenB, int  fee)
        {
            var createPoolFunction = new CreatePoolFunction();
                createPoolFunction.TokenA = tokenA;
                createPoolFunction.TokenB = tokenB;
                createPoolFunction.Fee = fee;
            
             return ContractHandler.SendRequestAsync(createPoolFunction);
        }

        public Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(string tokenA, string tokenB, int  fee, CancellationTokenSource cancellationToken = null)
        {
            var createPoolFunction = new CreatePoolFunction();
                createPoolFunction.TokenA = tokenA;
                createPoolFunction.TokenB = tokenB;
                createPoolFunction.Fee = fee;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createPoolFunction, cancellationToken);
        }

        public Task<string> EnableFeeAmountRequestAsync(EnableFeeAmountFunction enableFeeAmountFunction)
        {
             return ContractHandler.SendRequestAsync(enableFeeAmountFunction);
        }

        public Task<TransactionReceipt> EnableFeeAmountRequestAndWaitForReceiptAsync(EnableFeeAmountFunction enableFeeAmountFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(enableFeeAmountFunction, cancellationToken);
        }

        public Task<string> EnableFeeAmountRequestAsync(int fee, int  tickSpacing)
        {
            var enableFeeAmountFunction = new EnableFeeAmountFunction();
                enableFeeAmountFunction.Fee = fee;
                enableFeeAmountFunction.TickSpacing = tickSpacing;
            
             return ContractHandler.SendRequestAsync(enableFeeAmountFunction);
        }

        public Task<TransactionReceipt> EnableFeeAmountRequestAndWaitForReceiptAsync(int fee, int tickSpacing, CancellationTokenSource cancellationToken = null)
        {
            var enableFeeAmountFunction = new EnableFeeAmountFunction();
                enableFeeAmountFunction.Fee = fee;
                enableFeeAmountFunction.TickSpacing = tickSpacing;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(enableFeeAmountFunction, cancellationToken);
        }

        public Task<int> FeeAmountTickSpacingQueryAsync(FeeAmountTickSpacingFunction feeAmountTickSpacingFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FeeAmountTickSpacingFunction, int>(feeAmountTickSpacingFunction, blockParameter);
        }

        
        public Task<int> FeeAmountTickSpacingQueryAsync(int fee, BlockParameter blockParameter = null)
        {
            var feeAmountTickSpacingFunction = new FeeAmountTickSpacingFunction();
                feeAmountTickSpacingFunction.Fee = fee;
            
            return ContractHandler.QueryAsync<FeeAmountTickSpacingFunction, int>(feeAmountTickSpacingFunction, blockParameter);
        }

        public Task<string> GetPoolQueryAsync(GetPoolFunction getPoolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolFunction, string>(getPoolFunction, blockParameter);
        }

        
        public Task<string> GetPoolQueryAsync(string tokenA, string tokenB, int fee, BlockParameter blockParameter = null)
        {
            var getPoolFunction = new GetPoolFunction();
                getPoolFunction.TokenA = tokenA;
                getPoolFunction.TokenB = tokenB;
                getPoolFunction.Fee = fee;
            
            return ContractHandler.QueryAsync<GetPoolFunction, string>(getPoolFunction, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> SetOwnerRequestAsync(SetOwnerFunction setOwnerFunction)
        {
             return ContractHandler.SendRequestAsync(setOwnerFunction);
        }

        public Task<TransactionReceipt> SetOwnerRequestAndWaitForReceiptAsync(SetOwnerFunction setOwnerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setOwnerFunction, cancellationToken);
        }

        public Task<string> SetOwnerRequestAsync(string owner)
        {
            var setOwnerFunction = new SetOwnerFunction();
                setOwnerFunction.Owner = owner;
            
             return ContractHandler.SendRequestAsync(setOwnerFunction);
        }

        public Task<TransactionReceipt> SetOwnerRequestAndWaitForReceiptAsync(string owner, CancellationTokenSource cancellationToken = null)
        {
            var setOwnerFunction = new SetOwnerFunction();
                setOwnerFunction.Owner = owner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setOwnerFunction, cancellationToken);
        }
    }
}
