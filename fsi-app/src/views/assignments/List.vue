<template>
    <div class="container">
        <table class="table table-dark" v-if="jobList.length">
            <thead>
                <tr>
                    <th scope="col">Id</th>
                    <th scope="col">Job Name</th>
                    <th scope="col">Job Description</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="job in jobList">
                    <td>{{ job.Id }}</td>
                    <td>{{ job.Name }}</td>
                    <td>{{ job.Description }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<style>

</style>

<script>
export default {
	name: 'AssignmentList',

	data: function () {
		return {
			query: '',
			jobList: []
		}
	},

	beforeMount: function () {
		this.getJobList()
	},

	mounted: function () {
		// Upon component render
	},

	beforeDestroy: function () {
		// Before going away from the component
	},

	methods: {
		getJobList: function () {
			window.axios.get(this.route('Job/Search'), {
				'query': this.query
			}).then(response => {
				this.jobList = response.data
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
