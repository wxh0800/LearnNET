<template>
	<div class="container">
		<div class="card bg-light mb-3">
			<div class="card-header">
				FTP Job Status
			</div>
			<div class="card-body">
				<div v-if="message" class="alert alert-success">{{ message }}</div>
				<div v-if="error" class="alert alert-danger">{{ error }}</div>
				<div class="input-group mb-3">
					<input type="text" class="form-control" placeholder="Job ID" v-model="jobId">
					<div class="input-group-append">
						<button class="btn btn-primary" type="button" @click="getJobStatus">Get Status</button>
					</div>
				</div>
			</div>
		</div>

		<div class="card card-body test" v-if="jobName">
			<div>Job ID: {{ jobId }}</div>
			<div>Name: {{ jobName }}</div>
			<div>Status: {{ jobLastRunStatus }}</div>
			<div>Last Run: {{ jobLastRun }}</div>
		</div>
	</div>
</template>

<style lang="scss">
$blue: blue;

.test {
	color: $blue;
}
</style>

<script>
export default {
	name: 'Home',

	data: function () {
		return {
			jobId: '',
			jobName: '',
			jobLastRunStatus: '',
			jobLastRun: '',
			message: '',
			error: ''
		}
	},

	mounted: function () {
		console.log('The component is loaded')
	},

	methods: {
		getJobStatus: function () {
			this.message = ''
			this.error = ''

			window.axios.get(this.route('Job/Status'), {
				'id': this.jobId
			}).then(response => {
				this.message = 'Success'

				response = response.data
				this.jobId = response.Id
				this.jobName = response.Name
				this.jobLastRunStatus = response.LastRunStatus
				this.jobLastRun = response.LastRun
			}).catch(error => {
				if (typeof error.response === 'undefined') {
					this.error = error.message
				}
				else {
					this.error = error.response.data.message
				}
			})
		}
	}
}
</script>
