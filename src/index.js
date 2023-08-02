const ethers = require('ethers')
const fs = require('fs/promises');

const API_KEY = 'https://eth-mainnet.g.alchemy.com/v2/JCNCAmqFfaWQ9WQrW143reOVrnRg1YfY'; // you need to put your web3 provider (Alchemy, Infura, Geth, etc) api url here
const provider = new ethers.JsonRpcProvider(API_KEY);

async function main() {
    while (1) {
        let wallet = ethers.Wallet.createRandom(); // create a new wallet
        let mnemonic = wallet.mnemonic.phrase; // mnemonic
        let address = wallet.address; // address
        let balance = ethers.formatEther(await provider.getBalance(wallet.address)); // balance
        console.log(balance)
    
        if (balance !== '0.0') { // found ether in wallet
            let crackedData;
            await fs.readFile('./cracked.json') // log to json file
                .then(data => {
                    crackedData = JSON.parse(data);
                })
                .catch(err => {
                    throw err;
                });
    
            crackedData[address] = {"mnemonic": mnemonic, "balance": balance};
            await fs.writeFile('./cracked.json', JSON.stringify(crackedData, null, 4), 'utf8');
        }
    }
}

main()