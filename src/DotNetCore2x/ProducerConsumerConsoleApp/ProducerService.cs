using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerConsoleApp {
	public class ProducerService : WorkerService {
		private readonly IBlockingQueue<IEnumerable<byte>> _queue;

		public ProducerService(IApplicationLifetime lifetime, IBlockingQueue<IEnumerable<byte>> queue)
			: base(lifetime) {
			_queue = queue;
		}

		protected override async Task ExecuteCoreAsync(CancellationToken stoppingToken) {
			var random = new Random();

			while (!stoppingToken.IsCancellationRequested) {
				// ランダムな時間待機する
				var sec = random.Next(1, 5);

				Console.WriteLine($"{nameof(ProducerService)}: Wait {sec}s");
				await Task.Delay(TimeSpan.FromSeconds(sec));

				// ランダムな値をキューに追加する
				var bytes = new byte[5];
				random.NextBytes(bytes);

				Console.WriteLine($"{nameof(ProducerService)}: Enqueue(before) {HexHelper.ToString(bytes)}");
				_queue.Enqueue(bytes);
				Console.WriteLine($"{nameof(ProducerService)}: Enqueue(after) {HexHelper.ToString(bytes)}");
			}
		}
	}
}
